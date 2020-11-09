using System;

namespace Zadatak01
{
    public class Stove : ISwitchable
    {
        public enum StoveType
        {
            Electric,
            Gas,
            Combo
        }
        public string Manufacturer { get; set; }
        public StoveType Type { get; set; }
        public void SwitchOn() => Console.WriteLine("Don't put your hand on it.");

        public void SwitchOff() => Console.WriteLine("Still don't tho.");

        public override string ToString() => $"Manufacturer: {Manufacturer}, Type: {Type}";
    }
}