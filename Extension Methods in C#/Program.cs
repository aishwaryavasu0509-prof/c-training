using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_Methods_in_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Using the extension method on a string
            string message = "Hello, World!";
            int wordCount = message.WordCount();
            Console.WriteLine($"The message \"{message}\" has {wordCount} words.");

            // Using the extension method on an integer
            int number = 5;
            int squared = number.Square();
            Console.WriteLine($"The square of {number} is {squared}.");
        }
    }

    // Static class to contain extension methods
    public static class MyExtensions
    {
        // Extension method for string to count words
        public static int WordCount(this string str)
        {
            if (string.IsNullOrEmpty(str))
                return 0;

            string[] words = str.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }

        // Extension method for int to calculate square
        public static int Square(this int number)
        {
            return number * number;
        }
    }
}
