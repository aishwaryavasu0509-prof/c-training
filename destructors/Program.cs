using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace destructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating an instance of the ResourceHolder class
            ResourceHolder resourceHolder = new ResourceHolder();
            resourceHolder.UseResource();

            // Forcing garbage collection to demonstrate destructor call
            resourceHolder = null;
            GC.Collect();
            GC.WaitForPendingFinalizers();

            Console.WriteLine("End of Main method.");
        }
    }

    class ResourceHolder
    {
        // Constructor
        public ResourceHolder()
        {
            Console.WriteLine("ResourceHolder created.");
        }

        // Method to simulate resource usage
        public void UseResource()
        {
            Console.WriteLine("Using resource...");
        }

        // Destructor
        ~ResourceHolder()
        {
            Console.WriteLine("ResourceHolder destructor called. Cleaning up resources.");
        }
    }
}
    }
}
