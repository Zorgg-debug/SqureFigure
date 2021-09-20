using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqureFigure
{
    public class Figure
    {
        public double Cirlce(double radius) => Math.PI * Math.Pow(radius, 2);
        public double Triangle(double a, double b, double c)
        {
            List<double> katets = new List<double> { a, b, c };
            double max = katets.Max();
            katets.Remove(max);
            double s;
            if (Math.Sqrt(Math.Pow(katets[0], 2) + Math.Pow(katets[1], 2)) == max)
            {
                s = (katets[0] * katets[1]) / 2;
            }
            else
            {
                double p = (a + b + c) / 2;
                s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            }
            return s;
        }
    }
}
