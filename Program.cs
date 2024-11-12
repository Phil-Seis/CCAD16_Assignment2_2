using System;

namespace CCAD16_Assignment2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Would you like to select a circle or a square?");
            string userChoice = Console.ReadLine().ToLower();
            Shape shape;

            switch (userChoice)
            {
                case "circle":
                    Console.WriteLine("Please enter the radius: ");
                    double userRadius = Convert.ToDouble(Console.ReadLine());
                    shape = new Circle { Radius = userRadius, Name = "Circle" };
                    break;

                case "square":
                    Console.WriteLine("Please enter the side length: ");
                    double sideLength = Convert.ToDouble(Console.ReadLine());
                    shape = new Square { Side = sideLength, Name = "Square" };
                    break;

                default:
                    Console.WriteLine("Please choose 'circle' or 'square'.");
                    return;
            }

            Console.WriteLine($"The area of your {shape.Name} is: {shape.CalculateArea()}");
        }

        public abstract class Shape
        {
            public double ShapeId { get; set; }
            public string Name { get; set; }
            public string Color { get; set; }

            public abstract double CalculateArea();
        }

        public class Circle : Shape
        {
            public double Radius { get; set; }

            public override double CalculateArea()
            {
                return Math.PI * Math.Pow(Radius, 2);
            }
        }

        public class Square : Shape
        {
            public double Side { get; set; }

            public override double CalculateArea()
            {
                return Side * Side;
            }
        }
    }
}
