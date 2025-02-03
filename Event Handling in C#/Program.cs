using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace EventHandlerExample
{
    // Custom EventArgs class to hold event data
    public class CustomEventArgs : EventArgs
    {
        public string Message { get; }

        public CustomEventArgs(string message)
        {
            Message = message;
        }
    }

    // Publisher class that raises an event
    public class Publisher
    {
        // Event declaration using EventHandler<TEventArgs>
        public event EventHandler<CustomEventArgs> CustomEvent;

        // Method to raise the event
        public void RaiseEvent(string message)
        {
            OnCustomEvent(new CustomEventArgs(message));
        }

        // Protected virtual method to allow derived classes to override the event invocation behavior
        protected virtual void OnCustomEvent(CustomEventArgs e)
        {
            CustomEvent?.Invoke(this, e);
        }
    }

    // Subscriber class that handles the event
    public class Subscriber
    {
        private readonly string _name;

        public Subscriber(string name, Publisher publisher)
        {
            _name = name;
            // Subscribe to the event
            publisher.CustomEvent += HandleCustomEvent;
        }

        // Event handler method
        private void HandleCustomEvent(object sender, CustomEventArgs e)
        {
            Console.WriteLine($"{_name} received this message: {e.Message}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create a publisher instance
            Publisher publisher = new Publisher();

            // Create subscriber instances and subscribe to the event
            Subscriber subscriber1 = new Subscriber("Subscriber 1", publisher);
            Subscriber subscriber2 = new Subscriber("Subscriber 2", publisher);

            // Raise the event
            publisher.RaiseEvent("Hello, World!");

            // Unsubscribe subscriber1 from the event
            publisher.CustomEvent -= subscriber1.HandleCustomEvent;

            // Raise the event again
            publisher.RaiseEvent("Goodbye, World!");
        }
    }
}