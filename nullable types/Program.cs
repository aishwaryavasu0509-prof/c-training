using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nullable_types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaring nullable types
            int? nullableInt = null;
            double? nullableDouble = 3.14;
            bool? nullableBool = null;

            // Checking if nullable types have values
            if (nullableInt.HasValue)
            {
                Console.WriteLine($"nullableInt has a value: {nullableInt.Value}");
            }
            else
            {
                Console.WriteLine("nullableInt is null");
            }

            if (nullableDouble.HasValue)
            {
                Console.WriteLine($"nullableDouble has a value: {nullableDouble.Value}");
            }
            else
            {
                Console.WriteLine("nullableDouble is null");
            }

            if (nullableBool.HasValue)
            {
                Console.WriteLine($"nullableBool has a value: {nullableBool.Value}");
            }
            else
            {
                Console.WriteLine("nullableBool is null");
            }

            // Using the null-coalescing operator (??)
            int nonNullableInt = nullableInt ?? 0;
            Console.WriteLine($"nonNullableInt: {nonNullableInt}");

            // Using the null-conditional operator (?.)
            string str = null;
            int? length = str?.Length;
            Console.WriteLine($"Length of str: {length}");

            // Using GetValueOrDefault method
            int defaultInt = nullableInt.GetValueOrDefault();
            double defaultDouble = nullableDouble.GetValueOrDefault();
            bool defaultBool = nullableBool.GetValueOrDefault();
            Console.WriteLine($"defaultInt: {defaultInt}");
            Console.WriteLine($"defaultDouble: {defaultDouble}");
            Console.WriteLine($"defaultBool: {defaultBool}");

            // Assigning values to nullable types
            nullableInt = 42;
            nullableBool = true;

            // Checking values again after assignment
            Console.WriteLine($"nullableInt after assignment: {nullableInt}");
            Console.WriteLine($"nullableBool after assignment: {nullableBool}");

            // Using GetValueOrDefault method after assignment
            defaultInt = nullableInt.GetValueOrDefault();
            defaultBool = nullableBool.GetValueOrDefault();
            Console.WriteLine($"defaultInt after assignment: {defaultInt}");
            Console.WriteLine($"defaultBool after assignment: {defaultBool}");
        }
    }
}
