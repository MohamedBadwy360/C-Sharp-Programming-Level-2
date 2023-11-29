using System;

namespace _05.Multicast_Delegate
{
    internal class Program
    {
        public delegate void MyDelegate(string message);
        public static void Method1(string message)
        {
            Console.WriteLine($"Method 1 + {message}");
        }
        public static void Method2(string message)
        {
            Console.WriteLine($"Method 2 + {message}");
        }
        static void Main(string[] args)
        {
            MyDelegate myDelegate = Method1;
            myDelegate += Method2;

            myDelegate("Hello");

            myDelegate -= Method1;
            myDelegate("Another message");
        }
    }
}
