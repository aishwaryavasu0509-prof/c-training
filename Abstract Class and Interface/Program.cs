using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_and_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating instances of the concrete classes
            Car car = new Car("Toyota", "Camry", 2020);
            Bicycle bicycle = new Bicycle("Giant", "Escape 3");

            // Using the methods defined in the abstract class and interface
            car.DisplayInfo();
            car.StartEngine();
            car.Drive();

            bicycle.DisplayInfo();
            bicycle.Drive();
        }
    }

    // Abstract class
    abstract class Vehicle
    {
        // Properties
        public string Make { get; }
        public string Model { get; }

        // Constructor
        public Vehicle(string make, string model)
        {
            Make = make;
            Model = model;
        }

        // Abstract method
        public abstract void DisplayInfo();
    }

    // Interface
    interface IDriveable
    {
        void Drive();
    }

    // Concrete class inheriting from abstract class and implementing interface
    class Car : Vehicle, IDriveable
    {
        public int Year { get; }

        // Constructor
        public Car(string make, string model, int year)
            : base(make, model)
        {
            Year = year;
        }

        // Implementing abstract method
        public override void DisplayInfo()
        {
            Console.WriteLine($"Car: {Make} {Model}, Year: {Year}");
        }

        // Additional method
        public void StartEngine()
        {
            Console.WriteLine($"{Make} {Model} engine started.");
        }

        // Implementing interface method
        public void Drive()
        {
            Console.WriteLine($"{Make} {Model} is driving.");
        }
    }

    // Another concrete class inheriting from abstract class and implementing interface
    class Bicycle : Vehicle, IDriveable
    {
        // Constructor
        public Bicycle(string make, string model)
            : base(make, model)
        {
        }

        // Implementing abstract method
        public override void DisplayInfo()
        {
            Console.WriteLine($"Bicycle: {Make} {Model}");
        }

        // Implementing interface method
        public void Drive()
        {
            Console.WriteLine($"{Make} {Model} is being ridden.");
        }
    }
}
