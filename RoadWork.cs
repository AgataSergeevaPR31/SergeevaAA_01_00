using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SergeevaAA_01_00
{
    internal class RoadWork
    {
        //поля
        public double widthroad { get; set; }
        public  double lengthroad { get; set; }
        public double mass { get; set; }
        //статоический список объектов
        public static List<RoadWork> RoadWorkList = new List<RoadWork>();

        //конструктор
        public RoadWork(double widthroad, double lengthroad, double mass)
        {
            this.widthroad = widthroad;
            this.lengthroad = lengthroad;
            this.mass = mass;
        }

        //функци, определюща качество по заданной формуле
        public virtual double Q()
        {
            return widthroad * lengthroad * mass / 1000;
        }

        public virtual string GetInfo()
        {
            return $"Доброжные работы:  {widthroad}м х {lengthroad}м. Масса покрытия: {mass} кг/кв.м. Q = {Q()}";
        }

        public override string ToString()
        {
            return GetInfo();
        }

        //метод добавления в статический список
        public void AddToList()
        {
            RoadWorkList.Add(this);
        }

        public static void RemoveFromList(RoadWork work)
        {
            RoadWorkList.Remove(work);
        }

        public static void RemoveFromList(List<RoadWork> works)
        {
            foreach (var work in works.ToList())
            {
                RoadWorkList.Remove(work);
            }
        }
    }
}
