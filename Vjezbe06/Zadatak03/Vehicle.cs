using System;
using System.Threading.Channels;

namespace Zadatak03
{
    public abstract class Vehicle
    {
        public string Type => this.GetType().Name;
        public int ChassisNumber { get; set; }
        public double Acceleration { get; set; }
        public string Mark { get; set; }

        public abstract void Accelerate();
        public abstract void Decelerate();

        public Vehicle(double acceleration, string mark)
        {
            Acceleration = acceleration;
            Mark = mark;
        }
        public override string ToString() => $"{Type} >> Chassis: {ChassisNumber}, Mark: {Mark}, Acceleration: {Acceleration}";
    }
}