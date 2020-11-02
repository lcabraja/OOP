using System;
using System.Collections.Generic;
using System.Drawing;

namespace Zadatak02
{
    class Program
    {
        static void Main(string[] args)
        {
            Frog f1 = new Frog(12, Color.Aquamarine);
            Frog f2 = new Frog(12, Color.Aquamarine);

            Console.WriteLine(f1.GetHashCode());
            Console.WriteLine(f2.GetHashCode());

            ISet<Frog> set = new HashSet<Frog>
            {
                f1,
                f2
            };
        }
    }
}