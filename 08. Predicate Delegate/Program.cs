using System;

namespace _08.Predicate_Delegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool result = IsEvenPredicate(5);

            Console.WriteLine($"Is 5 even ? {result}");
        }
            
        public static Predicate<int> IsEvenPredicate = IsEven;
            
        public static bool IsEven(int x)
        {
            return (x % 2 == 0);
        }
    }
}
