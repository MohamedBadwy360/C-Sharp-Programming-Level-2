using System;
using System.Threading;

namespace _34.Synchronization_Example
{
    internal class Program
    {
        static int sharedCounter = 0;
        static object sharedLock = new object();
        static void Main(string[] args)
        {
            Thread t1 = new Thread(Increment);
            Thread t2 = new Thread(Increment);

            t1.Start();
            t2.Start();

            // Wait for both threads to complete
            t1.Join();
            t2.Join();

            Console.WriteLine($"Final Counter Value: {sharedCounter}");
            Console.ReadKey();
        }

        static void Increment()
        {
            lock (sharedLock)
            {
                for (int i = 0; i < 100; i++)
                {
                    sharedCounter++;
                }
            }
        }
    }
}
