using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleQ2
{
    //2: Create an abstract class Vehicle with a property Speed and an abstract method Drive().
    //Implement the Drive() method in two derived classes Car and Bicycle.


    internal class Program
    {
        public abstract class Vehicle
        {
            public int Speed { get; set; }

            public abstract void Drive();

        }

        public class Car : Vehicle
        {
            public override void Drive()
            {
                Console.WriteLine($"The car is driving at {Speed} km/h.");
            }
        }

        public class Bicycle : Vehicle
        {

            public override void Drive()
            {
                Console.WriteLine($"The Bicycle is driving at {Speed} km/h.");
            }
        }

        static void Main(string[] args)
        {
            Vehicle car = new Car() { Speed = 100 };
           car.Drive();

            Vehicle bicycle = new Bicycle() { Speed = 15 };
            bicycle.Drive();
        }
    }
}
