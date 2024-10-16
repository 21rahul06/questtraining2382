using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Day10aiignment1
{
    internal class CreditCard
    {
        public string Name;
        public long Cardno;
        public byte ExpiryMonth;
        public int ExpiryYear;
        public int Cvc;
        public void DisplayDetails()
        {
        Console.WriteLine($"Cardholder Name: {Name}");
        Console.WriteLine($"Card Number: {Cardno}");
        Console.WriteLine($"Expiry Date: {ExpiryMonth}-{ExpiryYear}");
        Console.WriteLine($"CVC: {Cvc}");
        }
    }
}
