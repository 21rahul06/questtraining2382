using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PredEvenQ11
{
    internal class Program
    {
        public static  bool IsEven(int number)
        {
            return number % 2 == 0; 
        }
        static void Main(string[] args)
        {
            Predicate<int> checkEven = IsEven;
            int num1 = 5;

            if (checkEven(num1))
            {
                Console.WriteLine($"{num1} is even.");
            }
            else
            {
                Console.WriteLine($"{num1} is odd.");
            }
        }
    }
}
