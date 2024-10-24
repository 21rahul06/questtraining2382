using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelQ8
{
    internal class Program
    {
        public static int GetStringLength(string input)
        {
            return input.Length;
        }
        static void Main(string[] args)
        {
            Func<string, int> stringLengthDel = GetStringLength;

            string input = "Hello world";
            int length = stringLengthDel(input);

            Console.WriteLine($"The length of the string \"{input}\" is: {length}");

        }
    }
}
