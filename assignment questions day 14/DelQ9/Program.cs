using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelQ9
{
    internal class Program
    {
        public static void PrintWelcome(string message)
        {
            Console.WriteLine(message);
        }
        static void Main(string[] args)
        {
            Action<string> PrintMessage = PrintWelcome;

            string welcomeMessage = "Welcome";
             
            PrintMessage(welcomeMessage);
        }
    }
}
