using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q12
{
    internal class Program
    {
        public static bool StartsWithA(string str)
        {
            return str.StartsWith("A", StringComparison.OrdinalIgnoreCase);
        }
        static void Main(string[] args)
        {
            Predicate<string> checkStartsWithA = StartsWithA;


            string name1 = "Apple";



            if (checkStartsWithA(name1))
            {
                Console.WriteLine($"{name1} starts with 'A'.");
            }
            else
            {
                Console.WriteLine($"{name1} does not start with 'A'.");
            }
        }
    }
}
