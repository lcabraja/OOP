using System;
using System.Collections.Generic;
using System.Numerics;
using static Zadatak03.ComplexNumber;

namespace Zadatak03
{
    class Program
    {
        static void Main(string[] args)
        {
            ComplexNumber cn1 = new ComplexNumber(3, 2);
            ComplexNumber cn2 = new ComplexNumber(3, 2);

            Console.WriteLine(cn1.Equals(cn2));
            Console.WriteLine(cn1 == cn2);
            
            ISet<ComplexNumber> set = new HashSet<ComplexNumber>
            {
                cn1,
                cn2
            };
            Console.WriteLine(cn1.GetHashCode());
            Console.WriteLine(cn2.GetHashCode());
            Console.WriteLine(set.Count);
        }
    }
}