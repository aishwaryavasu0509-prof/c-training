using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_Controls
{
    internal class Program
    {
        static void Main(string[] args)
        {
            csharp
using System;

namespace LoopControlsExample
    {
        class Program
        {
            static void Main(string[] args)
            {
                int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                int sum = 0;
                int count = 0;

                Console.WriteLine("Processing numbers...");

                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] % 2 == 0)
                    {
                        continue; // Skip even numbers
                    }

                    sum += numbers[i];
                    count++;

                    if (count == 5)
                    {
                        break; // Stop after processing 5 odd numbers
                    }
                }

                Console.WriteLine($"Sum of first 5 odd numbers: {sum}");

                // Using goto to jump to a label
                Console.WriteLine("Enter a number to find its position in the array (1-10):");
                int input = int.Parse(Console.ReadLine());

                goto FindNumber;

            FindNumber:
                bool found = false;
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] == input)
                    {
                        Console.WriteLine($"Number {input} found at position {i + 1}.");
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    Console.WriteLine($"Number {input} not found in the array.");
                }

                Console.WriteLine("Processing complete.");
            }
        }
    }
}
