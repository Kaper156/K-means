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
    public partial class Form1 : Form
    {
        PictureBox canvas;


        //Костыль СПРОСИТЬ
        bool is_coordinated = false;

        //Главный объект подсчетов
        Misc.Work worker;

        public Form1()
        {
            InitializeComponent();
            worker = new Misc.Work();
        }
    

        void init_coordinate_system()
        {
            canvas = pictureBox1;
            
            using (Graphics gdi = canvas.CreateGraphics())
            {
                gdi.Clear(Color.White);
                int x = canvas.Width,
                    y = canvas.Height;
                gdi.DrawLine(Pens.Red, new Point(0, y / 2), new Point(x, y / 2));
                gdi.DrawLine(Pens.Red, new Point(x / 2, 0), new Point(x / 2, y));
            }
            
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            //КОСТЫЛЬ
            if (!is_coordinated)
            {
                init_coordinate_system();
                is_coordinated = true;
            }

            using (Graphics gdi = canvas.CreateGraphics())
            {
                if (e.Button == MouseButtons.Left)
                {
                    gdi.FillEllipse(Brushes.Black, e.X, e.Y, 5, 5);
                    this.worker.elements.Add(new Misc.Element(e.X, e.Y));
                }
                else
                {
                    gdi.FillEllipse(Brushes.Red, e.X, e.Y, 10, 10);
                    this.worker.clusters.Add(new Misc.Cluster(e.X, e.Y));
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Костыльно
            List<Brush> brushes = new List<Brush>();
            brushes.Add(Brushes.Red);
            brushes.Add(Brushes.Yellow);
            brushes.Add(Brushes.Green);
            brushes.Add(Brushes.Cyan);
            brushes.Add(Brushes.Black);

            init_coordinate_system();

            foreach (Misc.Cluster cluster in worker.start())
            {
                //Костыльно
                Brush brush = brushes[0];
                brushes.RemoveAt(0);

                using (Graphics gdi = canvas.CreateGraphics())
                {
                    gdi.FillEllipse(brush, (int)cluster.X, (int)cluster.Y, 10, 10); 
                    foreach (Misc.Element element in cluster.elements)
                    {
                        gdi.FillEllipse(brush, (int)element.X, (int)element.Y, 5, 5); 
                    }
                }

            }
        }


    }
}
