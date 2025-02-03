using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace commandlinearguements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("No command line arguments provided.");
                return;
            }

            // Display the command line arguments
            Console.WriteLine("Command Line Arguments:");
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine($"Argument {i + 1}: {args[i]}");
            }

            // Example: Sum of integers passed as command line arguments
            int sum = 0;
            foreach (string arg in args)
            {
                if (int.TryParse(arg, out int number))
                {
                    sum += number;
                }
                else
                {
                    Console.WriteLine($"'{arg}' is not a valid integer.");
                }
            }

            Console.WriteLine($"Sum of valid integers: {sum}");
        }
    }
    }
}
