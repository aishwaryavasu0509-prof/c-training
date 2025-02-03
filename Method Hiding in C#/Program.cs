using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Hiding_in_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating an instance of the base class
            BaseClass baseClass = new BaseClass();
            baseClass.Display();

            // Creating an instance of the derived class
            DerivedClass derivedClass = new DerivedClass();
            derivedClass.Display();

            // Using a base class reference to a derived class object
            BaseClass baseRefToDerived = new DerivedClass();
            baseRefToDerived.Display();
        }
    }

    class BaseClass
    {
        public void Display()
        {
            Console.WriteLine("Display method in BaseClass.");
        }
    }

    class DerivedClass : BaseClass
    {
        public new void Display()
        {
            Console.WriteLine("Display method in DerivedClass.");
        }
    }
}
