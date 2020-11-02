using System;
using System.Drawing;

namespace Zadatak04
{
    public class Triangle : GeometricalFigure
    {
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }

        public override double Area
        {
            get
            {
                double s = (A + B + C) / 2;
                return Math.Sqrt(s * (s - A) * (s - B) * (s - C));
            }
        }

        public override double Perimeter { get => A + B + C; }

        public Triangle(Color color, int a, int b, int c) : base(color)
        {
            A = a;
            B = b;
            C = c;
        }
        
        public override string ToString() => base.ToString() + $" a: {A}, b: {B}, c: {C}";
    }
}