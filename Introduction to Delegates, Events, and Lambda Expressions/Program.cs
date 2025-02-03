using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction_to_Delegates__Events__and_Lambda_Expressions
{
    class Program
    {
        // Delegate declaration
        public delegate void Notify(string message);

        // Event declaration
        public static event Notify OnNotify;

        static void Main(string[] args)
        {
            // Subscribe to the event using a method
            OnNotify += DisplayMessage;

            // Subscribe to the event using a lambda expression
            OnNotify += (message) => Console.WriteLine($"Lambda received: {message}");

            // Trigger the event
            TriggerEvent("Hello, World!");

            // Using a delegate with a lambda expression
            Notify notifyDelegate = (message) => Console.WriteLine($"Delegate received: {message}");
            notifyDelegate("Hello from delegate!");

            // Unsubscribe from the event
            OnNotify -= DisplayMessage;
            OnNotify -= (message) => Console.WriteLine($"Lambda received: {message}");
        }

        static void TriggerEvent(string message)
        {
            // Check if there are any subscribers
            if (OnNotify != null)
            {
                OnNotify(message);
            }
        }

        static void DisplayMessage(string message)
        {
            Console.WriteLine($"Method received: {message}");
        }
    }
}
