using System;
using System.Collections.Generic;
using System.Net;

namespace Zadatak03
{
    class Program
    {
        static void Main(string[] args)
        {
            Car nokia = new Car(12.5, "benzin", 76878);
            SportsCar iphone = new SportsCar(110.5,"Ferrero Rocher", 789022, true);

            nokia.Drive();
            nokia.Stop();
            Console.WriteLine(nokia);
            Console.WriteLine(new string('-', Console.WindowWidth));
            iphone.Drive();
            iphone.Drift();
            iphone.Stop();
            Console.WriteLine(iphone);
            Console.WriteLine(new string('-', Console.WindowWidth));
            Car samsmung = iphone;
            samsmung.Drive();
            samsmung.Stop();

            if (samsmung is SportsCar jonbovi)
                jonbovi.Drift();
            Console.WriteLine(new string('-', Console.WindowWidth));

            IList<Car> Cars = new List<Car> {nokia, iphone, new Truck(1.2, "Mercadasa", 12, 100002, true)};

            foreach (var item in Cars)
            {
                item.Drive();
                if (item is SportsCar scitem)
                    scitem.Drift();
                item.Stop();
                PrintDetails(item);
            }
        }

        private static void PrintDetails(Car item)
        {
            Console.WriteLine(item);
        }
    }
}