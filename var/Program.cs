using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace var
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Implicitly typed local variables
            var integer = 10; // int
            var floatingPoint = 3.14; // double
            var text = "Hello, World!"; // string
            var isTrue = true; // bool
            var person = new Person("John", "Doe", 30); // Person

            // Displaying the values and types of the variables
            Console.WriteLine($"integer: {integer}, Type: {integer.GetType()}");
            Console.WriteLine($"floatingPoint: {floatingPoint}, Type: {floatingPoint.GetType()}");
            Console.WriteLine($"text: {text}, Type: {text.GetType()}");
            Console.WriteLine($"isTrue: {isTrue}, Type: {isTrue.GetType()}");
            Console.WriteLine($"person: {person.FirstName} {person.LastName}, Age: {person.Age}, Type: {person.GetType()}");

            // Implicitly typed array
            var numbers = new[] { 1, 2, 3, 4, 5 }; // int[]
            Console.WriteLine("\nnumbers array:");
            foreach (var number in numbers)
            {
                Console.WriteLine($"number: {number}, Type: {number.GetType()}");
            }
        }
    }

    class Person
    {
        // Properties
        public string FirstName { get; }
        public string LastName { get; }
        public int Age { get; }

        // Constructor
        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }
    }
}
