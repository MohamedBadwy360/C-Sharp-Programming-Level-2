using System;


namespace _24.Generic_Methods
{
    public class Utility
    {
        public static void Swap<T> (ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Usage with integers
            int a = 5, b = 6;
            Console.WriteLine($"Before Swap: a = {a} & b = {b}");
            Utility.Swap(ref a, ref b);
            Console.WriteLine($"After Swap: a = {a} & b = {b}");

            // Usage with strings
            string x = "Mohamed", y = "ELsaid";
            Console.WriteLine($"Before Swap: x = {x} & y = {y}");
            Utility.Swap(ref x, ref y);
            Console.WriteLine($"After Swap: x = {x} & y = {y}");
        }
    }
}
