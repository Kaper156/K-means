using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace K_means__WinForms_
{

    /*
     * Реализовать алгоритм кластеризации заданного набора точек из R2 на N кластеров по методу k-средних. 
     * Результат представить в виде графа связей между точками.
     */

    public partial class Form1 : Form
    {
        PictureBox canvas;

        //Плохо СПРОСИТЬ
        bool is_coordinated = false;

        //Главный объект подсчетов, приделать подсчет в отдельном треде с обратной связью
        Misc.Work worker;

        public Form1()
        {
            InitializeComponent();
            worker = new Misc.Work();
        }


        void init_coordinate_system()
        {
            using (Graphics gdi = pic_coord.CreateGraphics())
            {
                gdi.Clear(Color.White);
                int x = pic_coord.Width,
                    y = pic_coord.Height;
                gdi.DrawLine(Pens.Red, new Point(0, y / 2), new Point(x, y / 2));
                gdi.DrawLine(Pens.Red, new Point(x / 2, 0), new Point(x / 2, y));
            }

        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            //Плохо
            if (!is_coordinated)
            {
                init_coordinate_system();
                is_coordinated = true;
            }

            using (Graphics gdi = pic_coord.CreateGraphics())
            {
                if (e.Button == MouseButtons.Left)
                {
                    draw_point(gdi, e.X, e.Y, Brushes.Black);
                    this.worker.elements.Add(new Misc.Element(e.X, e.Y));
                }
                else
                {
                    draw_centroid(gdi, e.X, e.Y, Brushes.Red, 10);
                    this.worker.clusters.Add(new Misc.Cluster(e.X, e.Y));
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            worker.start();
            pic_coord.Refresh();
        }

        void draw_point(Graphics gdi, int x, int y, Brush brush, int size = 7)
        {
            int halfsize = size / 2;
            gdi.FillEllipse(brush, x - halfsize, y - halfsize, size, size);
            gdi.DrawEllipse(Pens.Black, x - halfsize, y - halfsize, size, size);
            pic_coord.Refresh();

        }

        void draw_centroid(Graphics gdi, int x, int y, Brush brush, int size = 15)
        {
            int halfsize = size / 2;
            draw_point(gdi, x, y, brush, size);
            gdi.DrawLine(Pens.Black, x, y + halfsize, x, y - halfsize);
            gdi.DrawLine(Pens.Black, x + halfsize, y, x - halfsize, y);
            pic_coord.Refresh();

        }

        private void pic_coord_Paint(object sender, PaintEventArgs e)
        {
            init_coordinate_system();
            //foreach (Misc.Cluster centroid in this.worker.clusters)
            //{
            //    foreach (Misc.Element dot in centroid.elements)
            //    {
            //        draw_point((int)dot.X, (int)dot.Y, Brushes.Brown);
            //    }
            //}


            //Плохо
            List<Brush> brushes = new List<Brush>();
            brushes.Add(Brushes.Red);
            brushes.Add(Brushes.Yellow);
            brushes.Add(Brushes.Green);
            brushes.Add(Brushes.Cyan);
            brushes.Add(Brushes.Black);
            brushes.Add(Brushes.DarkKhaki);
            brushes.Add(Brushes.DeepPink);

            init_coordinate_system();

            foreach (Misc.Cluster cluster in worker.start())
            {
                //Костыльно
                Brush brush = brushes[0];
                brushes.RemoveAt(0);

                using (Graphics gdi = pic_coord.CreateGraphics())
                {
                    //gdi.FillEllipse(brush, (int)cluster.X, (int)cluster.Y, 10, 10); 
                    draw_centroid(gdi, (int)cluster.X, (int)cluster.Y, brush, 10);
                    foreach (Misc.Element element in cluster.elements)
                    {
                        draw_point(gdi, (int)element.X, (int)element.Y, brush);
                    }
                }

            }
        }

    }
}
