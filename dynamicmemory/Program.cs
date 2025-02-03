using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dynamicmemory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Dynamic memory allocation for a single object
            Person person = new Person("John", "Doe", 30);
            Console.WriteLine($"Person: {person.FirstName} {person.LastName}, Age: {person.Age}");

            // Dynamic memory allocation for an array of objects
            Person[] people = new Person[3];
            people[0] = new Person("Alice", "Smith", 25);
            people[1] = new Person("Bob", "Johnson", 40);
            people[2] = new Person("Charlie", "Brown", 35);

            Console.WriteLine("\nPeople array:");
            foreach (var p in people)
            {
                Console.WriteLine($"Person: {p.FirstName} {p.LastName}, Age: {p.Age}");
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
