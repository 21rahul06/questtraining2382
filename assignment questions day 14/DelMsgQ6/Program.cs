using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DelMsgQ6
{
    //6: Create a delegate PrintMessage that takes a string as a parameter.
    //Write a method DisplayMessage that prints the string passed to it. Use the delegate to call DisplayMessage.


    public delegate void PrintMessage(string message);
    internal class Program
    {
        public static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }
        static void Main(string[] args)
        {
            PrintMessage printMessageDelegate = new PrintMessage(DisplayMessage);

            printMessageDelegate("Hello");

            printMessageDelegate("Hi,how are u?");


        }
    }
}
