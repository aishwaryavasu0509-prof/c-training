using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classandobject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating instances of the Car class
            Car car1 = new Car("Toyota", "Camry", 2020);
            Car car2 = new Car("Honda", "Civic", 2018);

            // Accessing properties and methods of the Car class
            Console.WriteLine($"Car 1: {car1.Make} {car1.Model}, Year: {car1.Year}");
            car1.Start();
            car1.Drive();

            Console.WriteLine($"Car 2: {car2.Make} {car2.Model}, Year: {car2.Year}");
            car2.Start();
            car2.Drive();
        }
    }

    class Car
    {
        // Properties
        public string Make { get; }
        public string Model { get; }
        public int Year { get; }

        // Constructor
        public Car(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
        }

        // Methods
        public void Start()
        {
            Console.WriteLine($"{Make} {Model} is starting.");
        }

        public void Drive()
        {
            Console.WriteLine($"{Make} {Model} is driving.");
        }
    }
}
    }
}
