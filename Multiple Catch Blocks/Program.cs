using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple_Catch_Blocks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Prompt user for input
                Console.Write("Enter a number: ");
                string input = Console.ReadLine();

                // Attempt to parse the input to an integer
                int number = int.Parse(input);

                // Perform a division operation
                int result = Divide(100, number);
                Console.WriteLine($"100 divided by {number} is {result}.");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error: Invalid input. Please enter a valid number.");
                Console.WriteLine($"Exception Message: {ex.Message}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
                Console.WriteLine($"Exception Message: {ex.Message}");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Error: The number entered is too large or too small.");
                Console.WriteLine($"Exception Message: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An unexpected error occurred.");
                Console.WriteLine($"Exception Message: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Execution of the try-catch block is complete.");
            }
        }

        static int Divide(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                throw new DivideByZeroException("Denominator cannot be zero.");
            }
            return numerator / denominator;
        }
    }
}
