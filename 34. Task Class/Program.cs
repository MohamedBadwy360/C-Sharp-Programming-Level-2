using System;
using System.Threading.Tasks;

namespace _34._Task_Class
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            // Create and run an asynchronous task
            Task<int> resultTask = PerformAsyncOperation();

            // Do some other work while waiting for the task to complete
            Console.WriteLine("Doing some other work...");

            // Wait for the task to complete and retrieve the result
            int result = await resultTask;

            // Process the result
            Console.WriteLine($"Result: {result}");
        }

        static async Task<int> PerformAsyncOperation()
        {
            // Simulate an asynchronous operation
            await Task.Delay(4000);

            // Return a result
            return 42;
        }
    }
}
