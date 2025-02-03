using System;

namespace DataTypesExample
{
    class Program
    {
        // Enum declaration
        enum DaysOfWeek
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }

        static void Main(string[] args)
        {
            // Variables and data types
            int age = 25; // Integer literal
            double height = 5.9; // Floating-point literal
            float weight = 70.5f; // Floating-point literal with 'f' suffix
            char grade = 'A'; // Character literal
            string name = "John"; // String literal
            bool isStudent = true; // Boolean literal
            decimal price = 99.99m; // Decimal literal with 'm' suffix

            // Enum usage
            DaysOfWeek today = DaysOfWeek.Monday;

            // Output the values
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Height: {height}");
            Console.WriteLine($"Weight: {weight}");
            Console.WriteLine($"Grade: {grade}");
            Console.WriteLine($"Is Student: {isStudent}");
            Console.WriteLine($"Price: {price}");
            Console.WriteLine($"Today is: {today}");
        }
    }
}
