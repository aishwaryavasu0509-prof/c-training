using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finalize_and_Dispose_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Using the ResourceHolder class with the Dispose pattern
            using (ResourceHolder resourceHolder = new ResourceHolder())
            {
                resourceHolder.UseResource();
            }

            // Forcing garbage collection to demonstrate finalizer call
            Console.WriteLine("Forcing garbage collection...");
            GC.Collect();
            GC.WaitForPendingFinalizers();

            Console.WriteLine("End of Main method.");
        }
    }

    class ResourceHolder : IDisposable
    {
        // Flag to indicate whether the object has been disposed
        private bool disposed = false;

        // Constructor
        public ResourceHolder()
        {
            Console.WriteLine("ResourceHolder created.");
        }

        // Method to simulate resource usage
        public void UseResource()
        {
            if (disposed)
                throw new ObjectDisposedException("ResourceHolder");

            Console.WriteLine("Using resource...");
        }

        // Public implementation of Dispose pattern callable by consumers
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        // Protected implementation of Dispose pattern
        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                // Free any other managed objects here.
                Console.WriteLine("Disposing managed resources.");
            }

            // Free any unmanaged objects here.
            Console.WriteLine("Disposing unmanaged resources.");

            disposed = true;
        }

        // Destructor (finalizer)
        ~ResourceHolder()
        {
            Dispose(false);
        }
    }
}
