using System;

namespace Zadatak03
{
    public class Car : Vehicle
    {

        public Car(double acceleration, string mark, int chassisNumber) : base(acceleration, mark)
        {
            ChassisNumber = chassisNumber;
        }
        
        public void Drive() {}
        public void Stop() {}


        public override void Accelerate()
        {
            Console.WriteLine($"{Type} is accelerating");
        }

        public override void Decelerate()
        {
            Console.WriteLine($"{Type} is decelerating");
        }
    }
}