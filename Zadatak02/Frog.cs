using System.Drawing;

namespace Zadatak02
{
    public class Frog
    {
        public int LegCount { get; set; }
        public Color Color { get; set; }

        public Frog(int legCount, Color color)
        {
            LegCount = legCount;
            Color = color;
        }

        public override string ToString() => $"Color: {Color}, Number of Legs: {LegCount}";
        
        public override bool Equals(object obj) =>
            (obj is Frog other) && other.Color.Equals(Color) && other.LegCount.Equals(LegCount);
        
        public override int GetHashCode() => Color.GetHashCode() * 31 + LegCount.GetHashCode();
        public static bool operator ==(Frog a, Frog b) => a.Equals(b);
        public static bool operator !=(Frog a, Frog b) => !(a == b);
    }
}