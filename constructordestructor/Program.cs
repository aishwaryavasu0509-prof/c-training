using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructordestructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Using the default constructor
            Car car1 = new Car();
            Console.WriteLine($"Car 1: {car1.Make} {car1.Model}, Year: {car1.Year}");

            // Using the parameterized constructor
            Car car2 = new Car("Honda", "Civic", 2018);
            Console.WriteLine($"Car 2: {car2.Make} {car2.Model}, Year: {car2.Year}");

            // Accessing the singleton instance
            Singleton instance = Singleton.Instance;
            instance.ShowMessage();
        }
    }

    class Car
    {
        // Properties
        public string Make { get; }
        public string Model { get; }
        public int Year { get; }

        // Default constructor
        public Car()
        {
            Make = "Unknown";
            Model = "Unknown";
            Year = 0;
        }

        // Parameterized constructor
        public Car(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
        }

        // Static constructor
        static Car()
        {
            Console.WriteLine("Static constructor called.");
        }
    }

    class Singleton
    {
        // Private static field to hold the single instance
        private static Singleton instance = null;

        // Private constructor to prevent instantiation
        private Singleton()
        {
        }

        // Public static property to get the single instance
        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }

        // Method to demonstrate functionality
        public void ShowMessage()
        {
            Console.WriteLine("Singleton instance method called.");
        }
    }
}
    }
}
