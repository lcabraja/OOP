using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Zadatak04
{
    class Program
    {
        static void Main(string[] args)
        {
            GeometricalFigure rectangle = new Rectangle(Color.Blue, 10, 20);
            GeometricalFigure circle = new Circle(Color.Turquoise, 10);
            Console.WriteLine(rectangle.Area);

            IList<GeometricalFigure> figures = new List<GeometricalFigure>
            {
                rectangle, circle, new Triangle(Color.Pink, 12, 3, 5)
            };

            figures.ToList().ForEach(Console.WriteLine);
        }
    }
}