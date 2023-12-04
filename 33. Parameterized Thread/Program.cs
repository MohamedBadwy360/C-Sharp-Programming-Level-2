using System;
using System.Threading;

namespace _32.Thread_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(() => Method1("Thread 1"));
            t.Start();
            //t.Join();
            //Method1();

                for (byte i = 0; i <= 20; i++)
            {
                Console.WriteLine($"Main => {i}");
                Thread.Sleep(500);
            }
        }

        static void Method1(string threadName)
        {
            for (byte i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{threadName} Method 1 => {i}");
                Thread.Sleep(500);
            }
        }
    }
}
