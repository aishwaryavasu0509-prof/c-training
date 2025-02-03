using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace innerexpressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Attempt to perform an operation that may throw an exception
                PerformOperation();
            }
            catch (CustomException ex)
            {
                Console.WriteLine("A custom exception occurred.");
                Console.WriteLine($"Exception Message: {ex.Message}");
                if (ex.InnerException != null)
                {
                    Console.WriteLine($"Inner Exception: {ex.InnerException.Message}");
                }
            }
        }

        static void PerformOperation()
        {
            try
            {
                // Simulate an operation that throws an exception
                throw new InvalidOperationException("An invalid operation occurred.");
            }
            catch (InvalidOperationException ex)
            {
                // Catch the original exception and throw a new custom exception with the original exception as the inner exception
                throw new CustomException("An error occurred in PerformOperation.", ex);
            }
        }
    }

    // Custom exception class
    public class CustomException : Exception
    {
        public CustomException() { }

        public CustomException(string message)
            : base(message) { }

        public CustomException(string message, Exception inner)
            : base(message, inner) { }
    }
}
