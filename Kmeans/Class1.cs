using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Kmeans
{
    
    //public class CentroidWithoutElementsException : System.Exception {
    //    public CentroidWithoutElementsException() { }

    //    public CentroidWithoutElementsException(string message) : base(message) { }

    //    public CentroidWithoutElementsException(string message, Exception inner) : base(message, inner) { }
    //}

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
            get { return _x; }
            set { _x = value; }
        }
        public double Y
        {
            get { return _y; }
            set { _y = value; }
        }
    }

    class Cluster : Element
    {
        public Cluster(double x, double y, Color color)
            : base(x, y)
        {
            this.X = x;
            this.Y = y;

            this.elements = new ObservableCollection<Element>();
            brush = new SolidBrush(color);
        }

        public ObservableCollection<Element> elements;

        public SolidBrush brush;

        public double refind_position()
        {
            //Разница нового и старого расстояния
            double infelicity = 0;
            //Находим кординаты центра множества точек
            double _x = 0, _y = 0;
            foreach (Element el in this.elements)
            {
                _x += el.X;
                _y += el.Y;
            }

            infelicity = Math.Sqrt(Math.Pow(this.X - _x / elements.Count, 2) + Math.Pow(this.Y - _y / elements.Count, 2));

            //Новые средние координаты
            this.X = _x / elements.Count;
            this.Y = _y / elements.Count;
            return infelicity;
        }

    }

    class Work
    {
        public ObservableCollection<Element> elements;

        public ObservableCollection<Element> unstacked;

        public ObservableCollection<Cluster> clusters;
        
        private double max_infelicity;
        
        public double MaxInfelicity
        {
            get
            {
                return max_infelicity;
            }
            set
            {
                max_infelicity = value;
            }
        }

        public Work(double max_infelicity=0.1)
        {

            this.elements = new ObservableCollection<Element>();
            this.unstacked = new ObservableCollection<Element>();
            this.clusters = new ObservableCollection<Cluster>();
            this.MaxInfelicity = max_infelicity;
        }

        void prepare()
        {
            //Добавить новые элементы
            foreach (var element in this.unstacked)
            {
                this.elements.Add(element);
            }
            this.unstacked.Clear();
            //Очистка элементов кластера
            foreach (Cluster cluster in this.clusters)
            {
                cluster.elements.Clear();
            }
        }

        void calc_elements()
        {
            //Обходим каждый элемент и смотрим, к какому центроиду какого кластера он является близлежащим.
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
        }

        bool calc_clusters()
        {

            //Пересчет координат центроид
            //Флаг за изменение позиции хотя бы одного центроида
            bool is_one_changed = false;
            foreach (Cluster cluster in this.clusters)
            {
                double infelicity = cluster.refind_position();
                is_one_changed = is_one_changed || infelicity >= max_infelicity;
            }
            return is_one_changed;
        }

        bool step()
        {
            prepare();

            calc_elements();
            return calc_clusters();
        }
        public ObservableCollection<Cluster> start()
        {
            while (step())
            {
                ;
            }

            return this.clusters;
        }

        double get_distance(Element el1, Element el2)
        {
            //Квадрат евклидова расстояния
            return Math.Pow((el1.X - el2.X), 2) + Math.Pow((el1.Y - el2.Y), 2);
        }

    }
}
