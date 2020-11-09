using System;

namespace Zadatak01
{
    public class LightBulb : ISwitchable
    {
        public double FillamentLength { get; set; }
        public int Power { get; set; }
        public void SwitchOn() => Console.WriteLine("I'm on fiiiire!");
        public void SwitchOff() => Console.WriteLine("I am no longer on fire.");

        public override string ToString() => $"Fillament length: Fillament Length: {FillamentLength.Format("W")}, Power: {Power.Format("mm")}";
    }
}