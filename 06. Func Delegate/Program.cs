using System;

namespace _06.Func_Delegate
{
    internal class Program
    {
        //delegate int SquareDelgate(int x);
        public static Func<int, int> square = SquareMethod;

        public static int SquareMethod(int x)
        {
            return x * x;
        }
        static void Main(string[] args)
        {
            //SquareDelgate square = new SquareDelgate(SquareMethod);

            int result = square(5);
            Console.WriteLine($"Result = {result}");
        }
    }
}
