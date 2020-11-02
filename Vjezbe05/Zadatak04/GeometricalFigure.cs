using System.Drawing;

namespace Zadatak04
{
    public abstract class GeometricalFigure
    {
        public Color Color { get; set; }
        public abstract double Area { get; }
        public abstract double Perimeter { get; }
        protected GeometricalFigure(Color color)
        {
            Color = color;
        }

        public override string ToString() => $"{this.GetType().Name} >> Color: {Color.Name}, Area: {Area}, Perimeter: {Perimeter}";
    }
}