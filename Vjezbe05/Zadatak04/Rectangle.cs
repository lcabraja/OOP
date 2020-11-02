using System.Drawing;

namespace Zadatak04
{
    public class Rectangle : GeometricalFigure
    {
        public int A { get; set; }
        public int B { get; set; }
        
        public override double Area
        {
            get => A * B;
        }

        public override double Perimeter
        {
            get => 2 * (A + B);
        }

        public Rectangle(Color color, int a, int b) : base(color)
        {
            A = a;
            B = b;
        }

        public override string ToString() => base.ToString() + $" a: {A}, b: {B}";
    }
}