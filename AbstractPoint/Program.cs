using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            abstractPoint.PointRepresentation rep1 = abstractPoint.PointRepresentation.Rectengular;
            abstractPoint.PointRepresentation rep2 = abstractPoint.PointRepresentation.Polar;

            Point a = new Point(rep1, 3, 4);
            Point b = new Point(rep2, 5, (Math.PI / 3));

            Console.WriteLine(a.ToString());
            Console.WriteLine();

            a.Move(7, 6);
            Console.WriteLine(a.ToString());
            Console.WriteLine();

            a.Rotate(Math.PI / 2);
            Console.WriteLine(a.ToString());
            Console.WriteLine();

            
            Console.WriteLine(b.ToString());
            Console.WriteLine();

            b.Rotate(Math.PI / 2);
            Console.WriteLine(b.ToString());
            Console.WriteLine();

            b.Move(6, 7);
            Console.WriteLine(b.ToString());
            Console.WriteLine();
        }
    }
}
