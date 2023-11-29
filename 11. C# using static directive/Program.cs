using System;

// using static directive
using static System.Math;

namespace _11.C__using_static_directive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = Sqrt(8);
            Console.WriteLine($"X = {x}");
        }
    }
}
