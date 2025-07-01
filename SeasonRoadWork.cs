using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SergeevaAA_01_00
{
    internal class SeasonRoadWork : RoadWork
    {
        //поле класса
        public int MonthNumber { get; set; }

        //констурктор
        public SeasonRoadWork(double widthroad, double lengthroad, double mass, int monthNumber) : base(widthroad, lengthroad, mass)
        {
            this.MonthNumber = monthNumber;
        }

        //переопределение метода вычислени качества объекта
        public override double Q()
        {
            double baseQ = base.Q();

            if (MonthNumber >= 5 && MonthNumber <= 8)
            {
                return baseQ * 1.1;
            }
            else if (new[] { 3, 4, 9, 10 }.Contains(MonthNumber))
            {
                return baseQ * 1.6;
            }
            else
            {
                return baseQ * 2.1 + MonthNumber * 10;
            }
        }

        //переопределение метода вывода информации
        public override string GetInfo()
        {
            return base.GetInfo() + $". Месяц: {MonthNumber}. Qp = {Q()}";
        }

        public override string ToString()
        {
            return GetInfo();
        }
    }
}
