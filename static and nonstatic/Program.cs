using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_and_nonstatic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            / Accessing static members directly using the class name
            Console.WriteLine($"Initial value of static member: {MyClass.StaticValue}");
            MyClass.StaticValue = 100;
            Console.WriteLine($"Updated value of static member: {MyClass.StaticValue}");

            // Creating instances of MyClass
            MyClass obj1 = new MyClass();
        MyClass obj2 = new MyClass();

        // Accessing non-static members through instances
        obj1.NonStaticValue = 10;
            obj2.NonStaticValue = 20;

            Console.WriteLine($"Value of non-static member in obj1: {obj1.NonStaticValue}");
            Console.WriteLine($"Value of non-static member in obj2: {obj2.NonStaticValue}");

            // Accessing static method
            MyClass.StaticMethod();

            // Accessing non-static method
            obj1.NonStaticMethod();
            obj2.NonStaticMethod();
        }
}

class MyClass
{
    // Static member
    public static int StaticValue;

    // Non-static member
    public int NonStaticValue;

    // Static method
    public static void StaticMethod()
    {
        Console.WriteLine("This is a static method.");
    }

    // Non-static method
    public void NonStaticMethod()
    {
        Console.WriteLine("This is a non-static method.");
    }
}
    }
}
