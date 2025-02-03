using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ComprehensiveExample
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // LINQ Example
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var evenNumbers = numbers.Where(n => n % 2 == 0).ToList();
            Console.WriteLine("LINQ Example - Even Numbers:");
            evenNumbers.ForEach(n => Console.WriteLine(n));

            // Async and Await Example
            Console.WriteLine("\nAsync and Await Example:");
            try
            {
                string result = await PerformAsyncOperation();
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception caught: {ex.Message}");
            }

            // Task Cancellation using CancellationToken
            Console.WriteLine("\nTask Cancellation Example:");
            CancellationTokenSource cts = new CancellationTokenSource();
            Task task = PerformCancellableOperation(cts.Token);

            // Cancel the task after 2 seconds
            cts.CancelAfter(2000);

            try
            {
                await task;
            }
            catch (OperationCanceledException)
            {
                Console.WriteLine("Task was cancelled.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception caught: {ex.Message}");
            }
        }

        static async Task<string> PerformAsyncOperation()
        {
            await Task.Delay(1000); // Simulate an asynchronous operation
            return "Async operation completed.";
        }

        static async Task PerformCancellableOperation(CancellationToken token)
        {
            for (int i = 0; i < 5; i++)
            {
                token.ThrowIfCancellationRequested();
                Console.WriteLine($"Operation in progress... {i + 1}");
                await Task.Delay(1000, token); // Pass the token to support cancellation
            }
            Console.WriteLine("Cancellable operation completed.");
        }
    }
}
