using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IanimalQ3
{
    //3: Create an interface IAnimal with a method Speak().
    //Implement the interface in two classes Dog and Cat, each providing their own implementation of Speak().
    internal class Program
    {
       public interface IAnimal 
        {

            void Speak();
        
        }

        class Dog : IAnimal
        {
            public void Speak()
            {
                Console.WriteLine("Dog says bow bow");
            }
        }

        class Cat : IAnimal
        {
            public void Speak()
            {
                Console.WriteLine("Cat says mwoe mwoe");
            }
        }

        static void Main(string[] args)
        {
            IAnimal dog = new Dog();
            dog.Speak();

            IAnimal cat = new Cat();
            cat.Speak();
        }
    }
}
