using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeleQ5
{
    //5: Define a delegate Operation that takes two integers as parameters.
    //Write methods Add and Multiply that match this delegate signature. Demonstrate how to use the delegate to call these methods.

    public delegate int Operation(int a, int b);  
    internal class Program
    {
        public static int Add(int a, int b) 
        {
            return a + b;
        }

        public static int Multiply(int a, int b)
        {
            return a* b;    
        }
        static void Main(string[] args)
        {
             Operation addOperation = new Operation(Add);
             Operation multiplyOperation = new Operation(Multiply);

            int resAdd = addOperation(2, 7);
            Console.WriteLine($"Result of Addition :{resAdd}");

            int resMultiply = multiplyOperation(2, 7);
            Console.WriteLine($"Result of Multiplication : {resMultiply}");
        }
    }
}
