using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garbage_Collection_in.NET
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating instances of the ResourceHolder class
            for (int i = 0; i < 5; i++)
            {
                ResourceHolder resourceHolder = new ResourceHolder(i);
                resourceHolder.UseResource();
            }

            // Forcing garbage collection to demonstrate destructor call
            Console.WriteLine("Forcing garbage collection...");
            GC.Collect();
            GC.WaitForPendingFinalizers();

            Console.WriteLine("End of Main method.");
        }
    }

    class ResourceHolder
    {
        private int id;

        // Constructor
        public ResourceHolder(int id)
        {
            this.id = id;
            Console.WriteLine($"ResourceHolder {id} created.");
        }

        // Method to simulate resource usage
        public void UseResource()
        {
            Console.WriteLine($"ResourceHolder {id} is using resource.");
        }

        // Destructor
        ~ResourceHolder()
        {
            Console.WriteLine($"ResourceHolder {id} destructor called. Cleaning up resources.");
        }
    }
}
