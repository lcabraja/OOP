using System;

namespace Zadatak03
{
    public class SportsCar : Car
    {
        public bool RoofWindow { get; set; }

        public SportsCar(double acceleration, string mark, int chassisNumber, bool roofWindow) : base(acceleration, mark, chassisNumber)
        {
            RoofWindow = roofWindow;
        }
        public virtual void Drift() => Console.WriteLine($"{Type} drifting");
    }
}