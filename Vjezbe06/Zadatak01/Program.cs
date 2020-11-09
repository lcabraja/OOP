using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Zadatak01
{
    class Program
    {
        static void Main(string[] args)
        {
            ISwitchable lb = new LightBulb {FillamentLength = 12.55, Power = 29};
            ISwitchable s = new Stove {Manufacturer = "Samsung d.o.o.", Type = Stove.StoveType.Electric};
            IList<ISwitchable> list = new List<ISwitchable> {lb, s, new URC()};
            list.ToList().ForEach(item =>
            {
                Console.WriteLine();
                Console.WriteLine(item);
                item.SwitchOn();
                if (item is IRemoteControllable irc)
                {
                    irc.VolumeUp();
                    irc.VolumeDown();
                }

                item.SwitchOff();
            });
            EnumDemo();
        }

        private static void EnumDemo()
        {
            Console.WriteLine();
            var values = Enum.GetValues(typeof(Stove.StoveType));
            foreach (var value in values)
            {
                Console.WriteLine($"{(int) value}, {value}");
            }

            Console.WriteLine();
            if (Enum.TryParse("Electric", out Stove.StoveType type))
                Console.WriteLine(type);
            int val = 2;
            Console.WriteLine();
            if (Enum.IsDefined(typeof(Stove.StoveType), val))
            {
                type = (Stove.StoveType) val;
                Console.WriteLine(type);
            }
            
        }
    }
}