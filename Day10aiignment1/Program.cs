using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10aiignment1
{
    internal class Program
    {
        static List<CreditCard> creditCards = new List<CreditCard>();
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1.Add New Credit Card");
                Console.WriteLine("2.Search Credit Card by Card Number");
                Console.WriteLine("3.Update Credit Card");
                Console.WriteLine("4.Delete Credit Card");
                Console.WriteLine("5.Exit");
                Console.Write("Choose an option: ");

                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddCreditCard();
                        break;
                    case "2":
                        SearchCreditCard();
                        break;
                    case "3":
                        UpdateCreditCard();
                        break;
                    case "4":
                        DeleteCreditCard();
                        break;
                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }
            }
        }
        public static void AddCreditCard()
        {
            Console.Write("Enter card holder's name: ");
            var name = Console.ReadLine();

            Console.Write("Enter the card number: ");
            var cardNo = Console.ReadLine();

            Console.Write("Enter expiry in MM-YY: ");
            var expiry = Console.ReadLine();

            Console.Write("Enter CVC: ");
            var cvc = Console.ReadLine();

            var creditCard = new CreditCard
            {
                Name = name,
                Cardno = long.Parse(cardNo),
                ExpiryMonth = byte.Parse(expiry.Split('-')[0]),
                ExpiryYear = int.Parse(expiry.Split('-')[1]),
                Cvc = int.Parse(cvc)
            };

            creditCards.Add(creditCard);
            Console.WriteLine("Credit card added successfully.");
        }
        private static void UpdateCreditCard()
        {
            Console.Write("Enter the card number to update: ");
            long cardNo = long.Parse(Console.ReadLine());
            foreach (var c in creditCards)
            {
                if (c.Cardno == cardNo)
                {
                    Console.Write("Enter new expiry in MM-YY: ");
                    string[] expiry = Console.ReadLine().Split('-');

                    Console.Write("Enter new CVC: ");
                    c.Cvc = int.Parse(Console.ReadLine().Trim());

                    c.ExpiryMonth = byte.Parse(expiry[0]);
                    c.ExpiryYear = int.Parse(expiry[1]);

                    Console.WriteLine("Credit card updated successfully.");
                    break;
                }
            }
        }
        private static void SearchCreditCard()
        {
            Console.Write("Enter the card number to search: ");
            long cardNo = long.Parse(Console.ReadLine());




            foreach (var c in creditCards)
            {
                if (c.Cardno == cardNo)
                {
                    Console.WriteLine("Credit Card Found:");
                    c.DisplayDetails();
                }
            }
        }
        private static void DeleteCreditCard()
        {
            Console.Write("Enter the card number to delete: ");
            long cardNo = long.Parse(Console.ReadLine());
            foreach (var c in creditCards)
            {
                if (c.Cardno == cardNo)
                {
                    creditCards.Remove(c);
                    Console.WriteLine("Credit card deleted successfully.");
                    break;
                }
            }
        }
    }
}
