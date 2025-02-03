using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for loops
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Hi");
            }
            for(int i = 0;i < 10; i+=2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("what do you want me to write?");
            string text=Console.ReadLine();
            Console.WriteLine("how many times you need to print hi?");
            int num=Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= num; i++)
            {
                Console.WriteLine("hi");
            }

            // while loops
            int j = 0;
            while (j<10)
            {
                j++;
            }

            //consitional operator
            int age = 20;
            string verdict = age >= 18 ? "valid" : "invalid";
            Console.WriteLine(verdict);
            Console.WriteLine(age >= 18 ? "true" : "false");

            //formatting
            double value = 1000D / 12.34D;
            Console.WriteLine(value);
            Console.WriteLine(string.Format("{0:0.00}", value));
        }
    }
}
