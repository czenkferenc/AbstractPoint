using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractPoint
{
    abstract class abstractPoint
    {
        public enum PointRepresentation
        {
            Polar,
            Rectengular
        }

        protected abstract double x { get; }
        protected abstract double y { get; }
        protected abstract double r { get; set; }
        protected abstract double a { get; set; }

        public void Move(double dx, double dy)
        {
            double x = ConvToX(r, a);
            double y = ConvToY(r, a);
            
            x += dx;
            y += dy;

            r = ConvToR(x, y);
            a = ConvToA(x, y);
        }

        public void Rotate(double angle)
        {
            a += angle; 
        }

        public override string ToString()
        {
            double x = ConvToX(r, a);
            double y = ConvToY(r, a);
            return $"({x}, {y}) : [{r}, {a}]";
        }

        protected static double ConvToR(double x, double y)
        {
            return Math.Sqrt(x * x + y * y);
        }

        protected static double ConvToA(double x, double y)
        {
           return Math.Atan(y / x);
        }

        protected static double ConvToX(double r, double a)
        {
            return r * Math.Cos(a);
        }

        protected static double ConvToY(double r, double a)
        {
            return r * Math.Sin(a);
        }
    }
}
