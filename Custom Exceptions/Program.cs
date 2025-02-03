using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Prompt user for input
                Console.Write("Enter your age: ");
                string input = Console.ReadLine();

                // Attempt to parse the input to an integer
                int age = int.Parse(input);

                // Check if the age is valid
                ValidateAge(age);

                Console.WriteLine("Age is valid.");
            }
            catch (InvalidAgeException ex)
            {
                Console.WriteLine($"Custom Exception: {ex.Message}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error: Invalid input. Please enter a valid number.");
                Console.WriteLine($"Exception Message: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An unexpected error occurred.");
                Console.WriteLine($"Exception Message: {ex.Message}");
            }
        }

        static void ValidateAge(int age)
        {
            if (age < 0 || age > 120)
            {
                throw new InvalidAgeException("Age must be between 0 and 120.");
            }
        }
    }

    // Custom exception class
    public class InvalidAgeException : Exception
    {
        public InvalidAgeException() { }

        public InvalidAgeException(string message)
            : base(message) { }

        public InvalidAgeException(string message, Exception inner)
            : base(message, inner) { }
    }
}
