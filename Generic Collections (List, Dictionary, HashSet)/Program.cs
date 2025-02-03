using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Collections__List__Dictionary__HashSet_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // List<T>
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            Console.WriteLine("List<T>:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            // Adding an element to the list
            numbers.Add(6);
            Console.WriteLine("After adding 6:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            // Dictionary<TKey, TValue>
            Dictionary<string, string> capitals = new Dictionary<string, string>
            {
                { "USA", "Washington, D.C." },
                { "France", "Paris" },
                { "Japan", "Tokyo" }
            };
            Console.WriteLine("\nDictionary<TKey, TValue>:");
            foreach (KeyValuePair<string, string> kvp in capitals)
            {
                Console.WriteLine($"Country: {kvp.Key}, Capital: {kvp.Value}");
            }

            // Adding an element to the dictionary
            capitals["Germany"] = "Berlin";
            Console.WriteLine("After adding Germany:");
            foreach (KeyValuePair<string, string> kvp in capitals)
            {
                Console.WriteLine($"Country: {kvp.Key}, Capital: {kvp.Value}");
            }

            // HashSet<T>
            HashSet<string> fruits = new HashSet<string> { "Apple", "Banana", "Cherry" };
            Console.WriteLine("\nHashSet<T>:");
            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            // Adding an element to the hash set
            fruits.Add("Date");
            Console.WriteLine("After adding Date:");
            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            // Attempting to add a duplicate element
            bool added = fruits.Add("Apple");
            Console.WriteLine($"Attempt to add duplicate 'Apple': {(added ? "Added" : "Not Added")}");
        }
    }
}
