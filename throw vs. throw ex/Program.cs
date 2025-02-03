using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace throw_vs.throw_ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Using throw:");
                Method1UsingThrow();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception caught in Main: {ex.Message}");
                Console.WriteLine($"Stack Trace:\n{ex.StackTrace}");
            }

            Console.WriteLine();

            try
            {
                Console.WriteLine("Using throw ex:");
                Method1UsingThrowEx();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception caught in Main: {ex.Message}");
                Console.WriteLine($"Stack Trace:\n{ex.StackTrace}");
            }
        }

        static void Method1UsingThrow()
        {
            try
            {
                Method2();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught in Method1UsingThrow");
                throw; // Re-throwing the exception while preserving the original stack trace
            }
        }

        static void Method1UsingThrowEx()
        {
            try
            {
                Method2();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught in Method1UsingThrowEx");
                throw ex; // Re-throwing the exception but resetting the stack trace
            }
        }

        static void Method2()
        {
            throw new InvalidOperationException("An error occurred in Method2.");
        }
    }
}
