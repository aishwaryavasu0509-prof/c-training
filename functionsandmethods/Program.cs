using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functionsandmethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            csharp
using System;

namespace FunctionsAndMethodsExample
    {
        class Program
        {
            static void Main(string[] args)
            {
                // Call by Value
                int a = 10;
                Console.WriteLine($"Before CallByValue: a = {a}");
                CallByValue(a);
                Console.WriteLine($"After CallByValue: a = {a}");

                // Call by Reference using ref
                int b = 20;
                Console.WriteLine($"\nBefore CallByReference (ref): b = {b}");
                CallByReference(ref b);
                Console.WriteLine($"After CallByReference (ref): b = {b}");

                // Call by Reference using out
                int c;
                Console.WriteLine($"\nBefore CallByReference (out): c is uninitialized");
                CallByReferenceOut(out c);
                Console.WriteLine($"After CallByReference (out): c = {c}");

                // User-defined function
                int result = Add(5, 7);
                Console.WriteLine($"\nResult of Add(5, 7): {result}");
            }

            // User-defined function to add two numbers
            static int Add(int x, int y)
            {
                return x + y;
            }

            // Function demonstrating Call by Value
            static void CallByValue(int x)
            {
                x = 50; // This change will not affect the original variable
                Console.WriteLine($"Inside CallByValue: x = {x}");
            }

            // Function demonstrating Call by Reference using ref
            static void CallByReference(ref int x)
            {
                x = 50; // This change will affect the original variable
                Console.WriteLine($"Inside CallByReference (ref): x = {x}");
            }

            // Function demonstrating Call by Reference using out
            static void CallByReferenceOut(out int x)
            {
                x = 50; // This change will affect the original variable
                Console.WriteLine($"Inside CallByReference (out): x = {x}");
            }
        }
    }
}
