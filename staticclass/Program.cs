using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticclass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Using static methods from the Utility class
            double radius = 5.0;
            double area = Utility.CalculateCircleArea(radius);
            Console.WriteLine($"The area of a circle with radius {radius} is {area}.");

            int number = 10;
            bool isEven = Utility.IsEven(number);
            Console.WriteLine($"{number} is even: {isEven}.");

            // Accessing static property
            Console.WriteLine($"The value of Pi is {Utility.Pi}.");
        }
    }

    // Static class
    public static class Utility
    {
        // Static property
        public static double Pi { get; } = 3.14159;

        // Static method to calculate the area of a circle
        public static double CalculateCircleArea(double radius)
        {
            return Pi * radius * radius;
        }

        // Static method to check if a number is even
        public static bool IsEven(int number)
        {
            return number % 2 == 0;
        }
    }
}
