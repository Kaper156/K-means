using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections.Specialized;

/*
 * DataGrid
 * Масштаирование графика
 * Загрузка csv
 * Перерисовка
 */

namespace Kmeans
{
    public partial class Form1 : Form
    {
        Work work;
        List<Color> used_colors;
        public Form1()
        {
            InitializeComponent();
            this.work = new Work(0.05);
            this.work.elements.CollectionChanged += ElementsChanged;
            this.work.elements.CollectionChanged += ElementsChanged;
            every_draw();
            used_colors = new List<Color>();
            
        }
                                              /* ОТРИСОВКА ПОЛЯ И ДОБАВЛЕНИЕ ЭЛЕМЕНТОВ */

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            every_draw();
        }

        //Отрисовка всего графика
        void every_draw()
        {

            using (Graphics gdi = canvas.CreateGraphics())
            {
                //Отрисовать координатную сетку
                gdi.Clear(Color.White);
                int x = canvas.Width,
                    y = canvas.Height;
                gdi.DrawLine(Pens.Red, new Point(0, y / 2), new Point(x, y / 2));
                gdi.DrawLine(Pens.Red, new Point(x / 2, 0), new Point(x / 2, y));


                //Нарисовать все объекты
                foreach (Cluster cluster in work.clusters)
                {
                        foreach (Element element in cluster.elements)
                        {
                            draw_point(gdi, element, cluster.brush);
                        }
                        draw_centroid(gdi, cluster);
                }
                foreach (Element element in work.unstacked)
                {
                    draw_point(gdi, element, Brushes.Black);
                }
                 

            }
            
        }

        void draw_point(Graphics gdi, Element point, Brush brush, int size = 7)
        {
                int halfsize = size / 2;
                gdi.FillEllipse(brush, (int)point.X - halfsize, (int)point.Y - halfsize, size, size);
                gdi.DrawEllipse(Pens.Black, (int)point.X - halfsize, (int)point.Y - halfsize, size, size);
            }

        void draw_centroid(Graphics gdi, Cluster centroid, int size = 15)
        {
            try
            {

                int halfsize = size / 2;
                draw_point(gdi, centroid, centroid.brush, size);
                gdi.DrawLine(Pens.Black, (int)centroid.X, (int)centroid.Y + halfsize, (int)centroid.X, (int)centroid.Y - halfsize);
                gdi.DrawLine(Pens.Black, (int)centroid.X + halfsize, (int)centroid.Y, (int)centroid.X - halfsize, (int)centroid.Y);
            
            }
            catch (OverflowException)
            {
                //У центроиды нет точек
                used_colors.Remove(centroid.brush.Color);
            }

        }

        //отвечает за добавление точек на полотно
        private void canvas_MouseClick(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                //простая точка
                case MouseButtons.Left:
                    {
                        work.unstacked.Add(new Element(e.X, e.Y));
                    }
                    break;
                //центроида
                case MouseButtons.Right:
                    {
                        work.clusters.Add(new Cluster(e.X, e.Y, do_new_rnd_color()));
                    }
                    break;
            }
            //Не нужен. вызывается от события
            //every_draw();
        }

        private Color do_new_rnd_color()
        {
            Color color;
            do
            {
                Random randomGen = new Random();
                KnownColor[] names = (KnownColor[])Enum.GetValues(typeof(KnownColor));
                KnownColor randomColorName = names[randomGen.Next(names.Length)];
                color = Color.FromKnownColor(randomColorName);
            }
            while (this.used_colors.Contains(color));
            this.used_colors.Add(color);
            return color;
        }

                                                                /* ЛОГИКА ПРОГРАММЫ */


        void ElementsChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add: // если добавление
                    break;
                case NotifyCollectionChangedAction.Remove: // если удаление
                    break;
                case NotifyCollectionChangedAction.Replace: // если замена
                    break;
            }
        }

        void ClustersChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add: // если добавление
                    break;
                case NotifyCollectionChangedAction.Remove: // если удаление
                    break;
                case NotifyCollectionChangedAction.Replace: // если замена
                    break;
            }
        }

        void UnstackedChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add: // если добавление
                    break;
                case NotifyCollectionChangedAction.Remove: // если удаление
                    break;
                case NotifyCollectionChangedAction.Replace: // если замена
                    break;
            }
        }
              
        private void btn_start_Click(object sender, EventArgs e)
        {
                work.start();
                every_draw();
        }

        private void Form1_Move(object sender, EventArgs e)
        {
            every_draw();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            every_draw();
        }

    }
}
