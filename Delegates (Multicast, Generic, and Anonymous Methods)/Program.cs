using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates__Multicast__Generic__and_Anonymous_Methods_
{
    internal class Program
    {
        class Program
        {
            // Multicast delegate declaration
            public delegate void MulticastDelegate(string message);

            static void Main(string[] args)
            {
                // Multicast Delegate
                MulticastDelegate multicast = Method1;
                multicast += Method2;
                Console.WriteLine("Multicast Delegate:");
                multicast("Hello from Multicast Delegate!");

                // Generic Delegate
                Action<string> genericDelegate = GenericMethod;
                Console.WriteLine("\nGeneric Delegate:");
                genericDelegate("Hello from Generic Delegate!");

                // Anonymous Method
                Action<string> anonymousMethod = delegate (string message)
                {
                    Console.WriteLine($"Anonymous Method received: {message}");
                };
                Console.WriteLine("\nAnonymous Method:");
                anonymousMethod("Hello from Anonymous Method!");

                // Lambda Expression as Anonymous Method
                Action<string> lambdaExpression = (message) => Console.WriteLine($"Lambda Expression received: {message}");
                Console.WriteLine("\nLambda Expression:");
                lambdaExpression("Hello from Lambda Expression!");
            }

            static void Method1(string message)
            {
                Console.WriteLine($"Method1 received: {message}");
            }

            static void Method2(string message)
            {
                Console.WriteLine($"Method2 received: {message}");
            }

            static void GenericMethod(string message)
            {
                Console.WriteLine($"GenericMethod received: {message}");
            }
        }
    }
