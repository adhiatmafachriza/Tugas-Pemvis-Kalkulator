using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class Trigonometri
    {
        public double calculateSin(double num)
        {
            double b = (num * (Math.PI)) / 180;
            return Math.Sin(b);
        }

        public double calculateCos(double num)
        {
            double b = (num * (Math.PI)) / 180;
            return Math.Cos(b);
        }

        public double calculateTan(double num)
        {
            double b = (num * (Math.PI)) / 180;
            return Math.Tan(b);
        }
    }
}
