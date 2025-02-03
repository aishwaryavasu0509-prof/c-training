using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Encapsulation: Creating an instance of the Person class
            Person person = new Person("John", "Doe", 30);
            Console.WriteLine($"Person: {person.FirstName} {person.LastName}, Age: {person.Age}");

            // Inheritance: Creating an instance of the Employee class
            Employee employee = new Employee("Jane", "Smith", 28, "Software Engineer");
            Console.WriteLine($"Employee: {employee.FirstName} {employee.LastName}, Age: {employee.Age}, Position: {employee.Position}");

            // Polymorphism: Using the Speak method
            person.Speak();
            employee.Speak();

            // Abstraction: Using the abstract method
            employee.Work();
        }
    }

    // Encapsulation: Person class with private fields and public properties
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
            set { age = value; }
        }

        // Constructor
        public Person(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        // Virtual method for polymorphism
        public virtual void Speak()
        {
            Console.WriteLine($"{FirstName} {LastName} is speaking.");
        }
    }

    // Inheritance: Employee class inheriting from Person
    class Employee : Person
    {
        // Additional property
        public string Position { get; set; }

        // Constructor
        public Employee(string firstName, string lastName, int age, string position)
            : base(firstName, lastName, age)
        {
            Position = position;
        }

        // Overriding the Speak method for polymorphism
        public override void Speak()
        {
            Console.WriteLine($"{FirstName} {LastName}, the {Position}, is speaking.");
        }

        // Abstract method implementation
        public void Work()
        {
            Console.WriteLine($"{FirstName} {LastName} is working as a {Position}.");
        }
    }
}
    }
}
