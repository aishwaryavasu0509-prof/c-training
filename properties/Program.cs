using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                // Creating an instance of Person
                Person person = new Person();

                // Setting properties
                person.FirstName = "John";
                person.LastName = "Doe";
                person.Age = 30;

                // Getting properties
                Console.WriteLine($"First Name: {person.FirstName}");
                Console.WriteLine($"Last Name: {person.LastName}");
                Console.WriteLine($"Age: {person.Age}");
                Console.WriteLine($"Full Name: {person.FullName}");

                // Trying to set an invalid age
                person.Age = -5;
                Console.WriteLine($"Age after setting invalid value: {person.Age}");
            }
        }

        class Person
        {
            // Private fields
            private string firstName;
            private string lastName;
            private int age;

            // Public properties
            public string FirstName
            {
                get { return firstName; }
                set { firstName = value; }
            }

            public string LastName
            {
                get { return lastName; }
                set { lastName = value; }
            }

            public int Age
            {
                get { return age; }
                set
                {
                    if (value >= 0)
                    {
                        age = value;
                    }
                    else
                    {
                        Console.WriteLine("Age cannot be negative.");
                    }
                }
            }

            // Read-only property
            public string FullName
            {
                get { return $"{FirstName} {LastName}"; }
            }
        }
    }
}
