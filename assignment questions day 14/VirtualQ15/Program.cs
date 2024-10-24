using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualQ15
{
    internal class Program
    {
        class Animal
        {
            
            public virtual void MakeSound()
            {
                Console.WriteLine("Some generic animal sound.");
            }
        }

       
        class Dog : Animal
        {
         
            public override void MakeSound()
            {
                Console.WriteLine("Bark!");
            }
        }

        static void Main(string[] args)
        {
            Animal myDog = new Dog();
            myDog.MakeSound();
        }
    }
}
