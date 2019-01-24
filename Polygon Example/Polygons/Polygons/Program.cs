using Polygon.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygons
{
    class Program
    {
        static void Main(string[] args)
        {
            //Concrete Regular Example
            var square = new Square(5);
            DisplayPolygon("Square", square);

            //Abstract Class example
            var traingle = new Traingle(10);
            DisplayPolygon("Traingle", traingle);

            //Interface Example
            var octagon = new Octagon(8, 5);
            DisplayPolygon("Octagon", octagon);
            Console.Read();
        }

        private static void DisplayPolygon(string polygonType, dynamic square)
        {
            Console.WriteLine(polygonType + " Number of Sides:" + square.NumberOfSides);
            Console.WriteLine(polygonType + " Side Length:" + square.SideLength);
            Console.WriteLine(polygonType + " Perimeter:" + square.GetPerimeter());
            Console.WriteLine(polygonType + " Area:" + square.GetArea() + "\n");
        }
    }
}
