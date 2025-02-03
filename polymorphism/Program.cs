using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Method Overloading
            Calculator calculator = new Calculator();
            Console.WriteLine("Method Overloading:");
            Console.WriteLine($"Add(int, int): {calculator.Add(5, 10)}");
            Console.WriteLine($"Add(double, double): {calculator.Add(5.5, 10.5)}");

            // Method Overriding
            Console.WriteLine("\nMethod Overriding:");
            Animal myDog = new Dog();
            myDog.MakeSound();

            // Operator Overloading
            Console.WriteLine("\nOperator Overloading:");
            ComplexNumber c1 = new ComplexNumber(1, 2);
            ComplexNumber c2 = new ComplexNumber(3, 4);
            ComplexNumber c3 = c1 + c2;
            Console.WriteLine($"({c1}) + ({c2}) = ({c3})");
        }
    }

    // Method Overloading
    class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public double Add(double a, double b)
        {
            return a + b;
        }
    }

    // Method Overriding
    class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes a sound.");
        }
    }

    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Dog barks.");
        }
    }

    // Operator Overloading
    class ComplexNumber
    {
        public double Real { get; }
        public double Imaginary { get; }

        public ComplexNumber(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }

        // Overloading the + operator
        public static ComplexNumber operator +(ComplexNumber c1, ComplexNumber c2)
        {
            return new ComplexNumber(c1.Real + c2.Real, c1.Imaginary + c2.Imaginary);
        }

        // Overriding ToString method for better display
        public override string ToString()
        {
            return $"{Real} + {Imaginary}i";
        }
    }
}
