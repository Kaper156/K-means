using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections.Specialized;
using System.IO;
/*
 * DataGrid
 * Масштаирование графика
 * Загрузка csv
 * Перерисовка
 */

namespace Kmeans
{
    /*
     * 
     * Реализовать алгоритм кластеризации заданного набора точек из 
     * R2 на N кластеров по методу k-средних. 
     * Результат представить в виде графа связей между точками.
     */
    public partial class Form1 : Form
    {
        Work work;
        List<Color> used_colors;
        public Form1()
        {
            InitializeComponent();
            //dgv_elements.AutoGenerateColumns = false;
            //dgv_groups.AutoGenerateColumns = false;
            this.work = new Work(0.05);
            used_colors = new List<Color>();
            dgv_elements.DataSource = work.elements;
            dgv_groups.DataSource = work.clusters;
            
        }
                                              /* ОТРИСОВКА ПОЛЯ И ДОБАВЛЕНИЕ ЭЛЕМЕНТОВ */

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //every_draw();
        }

        //Отрисовка всего графика
        void every_draw(Graphics gdi)
        {

            //using (Graphics gdi = canvas.CreateGraphics())
            //{
                //Отрисовать координатную сетку
                gdi.Clear(Color.White);
                int x = canvas.Width,
                    y = canvas.Height;
                gdi.DrawLine(Pens.Red, new Point(0, y / 2), new Point(x, y / 2));
                gdi.DrawLine(Pens.Red, new Point(x / 2, 0), new Point(x / 2, y));


                //Нарисовать все объекты
                foreach (Element element in work.elements)
                {
                    draw_point(gdi, element, Brushes.Black);
                }
                foreach (Cluster cluster in work.clusters)
                {
                        foreach (Element element in cluster.elements)
                        {
                            draw_point(gdi, element, cluster.brush);
                        }
                        draw_centroid(gdi, cluster);
                }
                
                 

            //}
            
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
                        work.elements.Add(new Element(e.X, e.Y));
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
            canvas.Invalidate();

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

                                                        /* СОБЫТИЯ ОТРИСОВКИ */

        private void Form1_Move(object sender, EventArgs e)
        {
            //every_draw();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            //every_draw();
        }

                                                         /* ЛОГИКА ПРОГРАММЫ */


        void ElementsChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add: // если добавление
                    {
                        
                    }
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
            try
            {

                work.start();
            }
            catch (AccessViolationException exc)
            {
                MessageBox.Show("Ошибка", exc.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            canvas.Invalidate();
        }

        private void открытьCsvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
             * Структура файла вида: 
             * х1
             * y1
             * Clusters (для разделения пустая строка)
             * x1
             * y1
            */

            var od = new OpenFileDialog();
            if (od.ShowDialog() == DialogResult.OK)
            {
                try
                {

                    StreamReader tr = new StreamReader(od.FileName);
                    string[] lines = tr.ReadToEnd().Split('\n');
                    tr.Close();
                    int i;
                    for (i = 0; i < lines.Length; i++)
                    {
                        //Пустая строка отделяет элементы от кластеров
                        if (lines[i].Trim() == "")
                        {
                            break;
                        }
                        Element el = new Element(Convert.ToDouble(lines[i]), Convert.ToDouble(lines[i + 1]));
                        work.unstacked.Add(el);

                        //Увеличить курсор (был на первой координате)
                        i++;
                    }
                    for (; i < lines.Length; i++)
                    {
                        Cluster cl = new Cluster(Convert.ToDouble(lines[i]), Convert.ToDouble(lines[i + 1]), do_new_rnd_color());
                        work.clusters.Add(cl);
                    }
                    tr.Close();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Ошибка","Неверный формат данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void сохранитьCsvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sd = new SaveFileDialog();
            if (sd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(sd.FileName);
                foreach (Cluster cl in work.clusters)
                {
                    sw.WriteLine(cl.X);
                    sw.WriteLine(cl.Y);

                }
                sw.Close();
            }
        }

        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            
            every_draw(e.Graphics);
        }


        private void btn_step_Click(object sender, EventArgs e)
        {
            try
            {

                work.step();
            }
            catch (AccessViolationException exc)
            {
                MessageBox.Show("Ошибка", exc.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            canvas.Invalidate();
        }

        private void dgv_groups_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            canvas.Invalidate();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            this.work.MaxInfelicity = (double)numericUpDown1.Value;
        }



    }
}
