using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Drawing;


namespace K_means__WinForms_.Misc
{


    public class Element
    {
        public Element(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }
        double _x, _y;
        public double X
        {
            get{ return _x;}
            set{ _x = value;}
        }
        public double Y
        {
            get{ return _y;}
            set{ _y = value;}
        }
    }

    class Cluster : Element
    {
        public Cluster(double x, double y)
            : base(x, y)
        {
            this.X = x;
            this.Y = y;

            this.elements = new List<Element>();
        }

        public List<Element> elements;

        public bool refind_position()
        {
            //Флаг
            bool isChanged = true;
         
            //Находим кординаты центра множества точек
            double _x = 0, _y = 0;
            foreach (Element el in this.elements)
            {
                _x += el.X;
                _y += el.Y;
            }
            //Если позиция изменилась, то !флаг
            if ((this.X == _x) && (this.Y == _y)) { isChanged = false; }
            this.X = _x / elements.Count;
            this.Y = _y / elements.Count;
            return isChanged;
        }

    }

    class Work
    {
        public List<Element> elements;
        public List<Cluster> clusters;


        public Work()
        {
            this.elements = new List<Element>();
            this.clusters = new List<Cluster>();
        }

        public List<Cluster> start()
        {

            //Очистка элементов кластера
            foreach (Cluster cluster in this.clusters)
            {
                cluster.elements.RemoveRange(0, cluster.elements.Count);
            }

            //Обходим каждый пиксель и смотрим, к какому центроиду какого кластера он является близлежащим.
            foreach (Element el in this.elements)
            {
                //Задали начальный минимум растояния, как до первого кластера
                Cluster closest = this.clusters[0];
                double min_distance = get_distance(el, this.clusters[0]);
                double distance;

                //Проверка расстояния между кластерами и данной точкой
                foreach (Cluster cluster in this.clusters)
                {
                    distance = get_distance(el, cluster);
                    if (distance < min_distance)
                    {
                        min_distance = distance;
                        closest = cluster;
                    }
                }

                //Присвоение точки ближайщему кластеру
                closest.elements.Add(el);
            }
            
            //Пересчет координат центроид
            //Флаг за изменение позиции хотя бы одного центроида
            bool is_one_changed = false;
            foreach (Cluster cluster in this.clusters)
            {
                is_one_changed = cluster.refind_position() || is_one_changed; 
            }
            /*
            if (is_one_changed)
            {
                this.start();
            }
             */

            return this.clusters;
        }

        double get_distance(Element el1, Element el2)
        {
            //Квадрат евклидова расстояния
            return  Math.Pow((el1.X - el2.X), 2) + Math.Pow((el1.Y - el2.Y), 2);
        }

    }

}
