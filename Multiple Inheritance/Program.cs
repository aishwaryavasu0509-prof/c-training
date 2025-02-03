using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating an instance of the AmphibiousVehicle class
            AmphibiousVehicle amphibiousVehicle = new AmphibiousVehicle("AmphiCar");

            // Using the methods defined in the interfaces
            amphibiousVehicle.Drive();
            amphibiousVehicle.Sail();
        }
    }

    // Interface for driving
    interface IDriveable
    {
        void Drive();
    }

    // Interface for sailing
    interface ISailable
    {
        void Sail();
    }

    // Class implementing multiple interfaces
    class AmphibiousVehicle : IDriveable, ISailable
    {
        public string Name { get; }

        // Constructor
        public AmphibiousVehicle(string name)
        {
            Name = name;
        }

        // Implementing IDriveable interface method
        public void Drive()
        {
            Console.WriteLine($"{Name} is driving on the road.");
        }

        // Implementing ISailable interface method
        public void Sail()
        {
            Console.WriteLine($"{Name} is sailing on the water.");
        }
    }
}
