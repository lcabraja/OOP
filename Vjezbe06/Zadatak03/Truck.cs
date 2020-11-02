namespace Zadatak03
{
    public class Truck : Car
    {
        public int Capacity { get; set; }
        public bool RaisedBed { get; set; }

        public Truck(double acceleration, string mark, int chassisNumber, int capacity, bool raisedBed) : base(acceleration, mark, chassisNumber)
        {
            Capacity = capacity;
            RaisedBed = raisedBed;
        }
    }
}