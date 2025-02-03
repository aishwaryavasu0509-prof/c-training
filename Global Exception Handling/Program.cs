using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Global_Exception_Handling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Subscribe to the global unhandled exception event
            AppDomain.CurrentDomain.UnhandledException += GlobalExceptionHandler;

            try
            {
                // Simulate an operation that throws an exception
                PerformOperation();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception caught in Main: {ex.Message}");
            }

            // Simulate an unhandled exception
            throw new InvalidOperationException("An unhandled exception occurred in Main.");
        }

        static void PerformOperation()
        {
            throw new InvalidOperationException("An error occurred in PerformOperation.");
        }

        static void GlobalExceptionHandler(object sender, UnhandledExceptionEventArgs e)
        {
            Exception ex = (Exception)e.ExceptionObject;
            Console.WriteLine("Global Exception Handler:");
            Console.WriteLine($"Exception Message: {ex.Message}");
            Console.WriteLine($"Stack Trace: {ex.StackTrace}");
        }
    }
}
