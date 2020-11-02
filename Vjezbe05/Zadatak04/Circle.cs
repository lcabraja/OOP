using System;
using System.Drawing;

namespace Zadatak04
{
    public class Circle : GeometricalFigure
    {
        public double Radius { get; set; }
        public double Diameter
        {
            get => Radius * 2;
            set => Radius = value / 2.0;
        }
        public override double Area
        {
            get => Math.Pow(Radius, 2.0) * Math.PI;
        }

        public override double Perimeter { get => 2 * Radius * Math.PI; }
        public Circle(Color color, double radius) : base(color) => Radius = radius;
        
        public override string ToString() => base.ToString() + $" r: {Radius}";
    }
}