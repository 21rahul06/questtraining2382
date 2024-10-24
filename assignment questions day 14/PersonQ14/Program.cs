using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonQ14
{
    abstract class Person
    {
   
        public abstract void Work();
    }

   
    class Doctor : Person
    {
    
        public override void Work()
        {
            Console.WriteLine("The doctor is diagnosing and treating patients.");
        }
    }

  
    class Engineer : Person
    {
    
        public override void Work()
        {
            Console.WriteLine("The engineer is designing and building structures.");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Person doctor = new Doctor();
            Person engineer = new Engineer();

            
            doctor.Work();
            engineer.Work();
        }
    }
}
