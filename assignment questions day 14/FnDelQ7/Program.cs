using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FnDelQ7
{
    internal class Program
    {
        public static int Add(int A,int B)
        {
            return A + B;
        }
        static void Main(string[] args) 
        {
            Func<int, int, int> sumDel = Add;
            int result = sumDel(7, 9);

            Console.WriteLine(result);
        }
    }
}
