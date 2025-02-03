using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace immutable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating an instance of ImmutablePerson
            ImmutablePerson person = new ImmutablePerson("John", "Doe", 30);

            // Accessing properties
            Console.WriteLine($"First Name: {person.FirstName}");
            Console.WriteLine($"Last Name: {person.LastName}");
            Console.WriteLine($"Age: {person.Age}");

            // Trying to modify the properties (uncommenting the following lines will cause compilation errors)
            // person.FirstName = "Jane";
            // person.LastName = "Smith";
            // person.Age = 25;

            // Creating a new instance to represent a modified state
            ImmutablePerson updatedPerson = person.WithAge(31);
            Console.WriteLine($"Updated Age: {updatedPerson.Age}");
        }
    }

    public class ImmutablePerson
    {
        // Read-only properties
        public string FirstName { get; }
        public string LastName { get; }
        public int Age { get; }

        // Constructor to initialize properties
        public ImmutablePerson(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        // Method to create a new instance with a modified age
        public ImmutablePerson WithAge(int newAge)
        {
            return new ImmutablePerson(FirstName, LastName, newAge);
        }
    }
    }
}
