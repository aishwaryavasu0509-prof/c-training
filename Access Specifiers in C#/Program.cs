using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_Specifiers_in_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating an instance of the AccessSpecifiersDemo class
            AccessSpecifiersDemo demo = new AccessSpecifiersDemo();

            // Accessing public member
            demo.PublicMethod();

            // Accessing internal member
            demo.InternalMethod();

            // Accessing protected internal member
            demo.ProtectedInternalMethod();

            // Accessing private member (uncommenting the following line will cause a compilation error)
            // demo.PrivateMethod();

            // Accessing protected member (uncommenting the following line will cause a compilation error)
            // demo.ProtectedMethod();

            // Accessing private protected member (uncommenting the following line will cause a compilation error)
            // demo.PrivateProtectedMethod();

            // Creating an instance of the DerivedClass to access protected and protected internal members
            DerivedClass derived = new DerivedClass();
            derived.AccessProtectedMembers();
        }
    }

    class AccessSpecifiersDemo
    {
        // Public member
        public void PublicMethod()
        {
            Console.WriteLine("Public method called.");
        }

        // Private member
        private void PrivateMethod()
        {
            Console.WriteLine("Private method called.");
        }

        // Protected member
        protected void ProtectedMethod()
        {
            Console.WriteLine("Protected method called.");
        }

        // Internal member
        internal void InternalMethod()
        {
            Console.WriteLine("Internal method called.");
        }

        // Protected internal member
        protected internal void ProtectedInternalMethod()
        {
            Console.WriteLine("Protected internal method called.");
        }

        // Private protected member
        private protected void PrivateProtectedMethod()
        {
            Console.WriteLine("Private protected method called.");
        }
    }

    class DerivedClass : AccessSpecifiersDemo
    {
        public void AccessProtectedMembers()
        {
            // Accessing protected member
            ProtectedMethod();

            // Accessing protected internal member
            ProtectedInternalMethod();

            // Accessing private protected member
            PrivateProtectedMethod();
        }
    }
}
