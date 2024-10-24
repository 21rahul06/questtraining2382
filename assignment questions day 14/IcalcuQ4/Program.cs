using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IcalcuQ4
{
    //4: Write an interface ICalculator that has methods Add(int a, int b) and Subtract(int a, int b).
    //Implement this interface in a SimpleCalculator class.

    internal class Program
    {
        public interface ICalculator 
        {
             int Add(int a, int b);
             int Subtract(int a,int b);
        }

        class SimpleCalculator : ICalculator
        {
            public int Add(int a, int b)
            {
              return a + b;
            }

            public int Subtract(int a, int b)
            {
                return (a - b);
            }

        }

        static void Main(string[] args)
        {
            ICalculator calculator = new SimpleCalculator();

            int AddRes = calculator.Add(1, 2);
            int SubRes = calculator.Subtract(1, 2);

            Console.WriteLine($" Addition : {AddRes}");
            Console.WriteLine($" Substraction : {SubRes}");



        }
    }
}
