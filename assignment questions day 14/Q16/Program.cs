using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q16
{
    internal class Program
    {
        class Employee
        {
            public string Name { get; set; }
            public double Salary { get; set; }

            public virtual double CalculateBonus()
            {
                
                return Salary * 0.05;
            }
        }


        class Manager : Employee
        {
         
            public override double CalculateBonus()
            {
                
                return Salary * 0.10;
            }
        }
        static void Main(string[] args)
        {
            Employee employee = new Employee { Name = "Devika", Salary = 5000 };
            Console.WriteLine($"{employee.Name}'s bonus: {employee.CalculateBonus()}");

           
            Manager manager = new Manager { Name = "Meenu", Salary = 8000 };
            Console.WriteLine($"{manager.Name}'s bonus: {manager.CalculateBonus()}");
        }
    }
}
