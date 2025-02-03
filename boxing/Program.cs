using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            csharp
using System;

namespace BoxingUnboxingExample
    {
        class Program
        {
            static void Main(string[] args)
            {
                // Boxing: Converting a value type to an object type
                int valueType = 123;
                object boxedValue = valueType; // Boxing
                Console.WriteLine($"Boxed value: {boxedValue}");

                // Unboxing: Converting an object type back to a value type
                object obj = 456; // Boxing
                int unboxedValue = (int)obj; // Unboxing
                Console.WriteLine($"Unboxed value: {unboxedValue}");

                // Demonstrating the difference between value type and reference type
                int originalValue = 789;
                object boxedOriginalValue = originalValue; // Boxing
                originalValue = 1000; // Changing the original value
                Console.WriteLine($"Original value after change: {originalValue}");
                Console.WriteLine($"Boxed original value: {boxedOriginalValue}"); // Boxed value remains unchanged

                // Unboxing with type checking
                object anotherBoxedValue = 321;
                if (anotherBoxedValue is int)
                {
                    int anotherUnboxedValue = (int)anotherBoxedValue; // Unboxing
                    Console.WriteLine($"Another unboxed value: {anotherUnboxedValue}");
                }
                else
                {
                    Console.WriteLine("The object is not an integer.");
                }
            }
    }
}
