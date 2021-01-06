using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zadatak01
{
    public class Program
    {
        private const char DEL = ',';
        public static void Main(string[] args)
        {
            ISet<int> a, b;
            //Get input from User for Set A
            do
            {
                Console.WriteLine("Insert Elements for A");

            } while (!TryParseElements(Console.ReadLine(), out a));
            //Get input from User for Set B
            do
            {
                Console.WriteLine("Insert Elements for B");

            } while (!TryParseElements(Console.ReadLine(), out b));
            
            //Union of sets A and B
            SortedSet<int> union = a.Union(b) as SortedSet<int>;
            PrintElements("A ∪ B = ", union);
            
            //Intersect of sets A and B
            SortedSet<int> intersect = a.Intersect(b) as SortedSet<int>;
            PrintElements("A ∩ B = ", intersect);
            
            //A except B
            SortedSet<int> except = a.Except(b) as SortedSet<int>;
            PrintElements("A \\ B = ", except);
            
            //Is A a subset of B
            Console.WriteLine($"A ⊂ B = {a.IsSubsetOf(b)}");
            
            //Is B a subset of A
            Console.WriteLine($"B ⊂ A = {a.IsSubsetOf(b)}");
        }

        private static void PrintElements(string message, IEnumerable<int> elements) => 
            Console.WriteLine($"{message}{{{string.Join(DEL,elements)}}}");

        private static bool TryParseElements(string line, out ISet<int> set)
        {
            set = new SortedSet<int>();
            string[] elements = line.Split(DEL);
            foreach (var element in elements)
            {
                try
                {
                    if (!set.Add(int.Parse(element)))
                    {
                        return false;
                    };
                }
                catch
                {
                    return false;
                }
            }
            return true;
        }
    }
}