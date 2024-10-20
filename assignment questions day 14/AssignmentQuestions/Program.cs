using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentQuestions
{

    /*1: Define an abstract class called Shape with an abstract method Area(). 
     * Create two derived classes Circle and Rectangle that implement the Area() method for calculating the area of the respective shapes.*/
    internal class Program
    {
        public abstract  class Shape
            {
            public abstract double Area();
            }

        public class Circle: Shape
        {
            public double Radius { get; set; }
            public override double Area()
            {
                return Math.PI * Radius * Radius;
            }
        }

        public class Rectangle : Shape
        {
            public double Width { get; set; }
            public double Height { get; set; }
            public override double Area()
            {
              return Width * Height;
            }

        }  
        
        static void Main(string[] args)
        {
            Shape circle = new Circle { Radius = 5 };
            Shape rectangle = new Rectangle { Width = 4, Height = 6 };


            Console.WriteLine($"The area of the circle is: {circle.Area()}");
            Console.WriteLine($"The area of the rectangle is: {rectangle.Area()}");
        }
    }
}
