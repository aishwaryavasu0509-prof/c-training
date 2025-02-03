using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constandreadonly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Accessing const field
            Console.WriteLine($"Constant value: {MyClass.ConstValue}");

            // Creating instances of MyClass
            MyClass obj1 = new MyClass(10);
            MyClass obj2 = new MyClass(20);

            // Accessing readonly fields
            Console.WriteLine($"Readonly value in obj1: {obj1.ReadOnlyValue}");
            Console.WriteLine($"Readonly value in obj2: {obj2.ReadOnlyValue}");
        }
    }

    class MyClass
    {
        // Const field
        public const int ConstValue = 100;

        // Readonly field
        public readonly int ReadOnlyValue;

        // Constructor to initialize readonly field
        public MyClass(int value)
        {
            ReadOnlyValue = value;
        }
    }
    }
}
