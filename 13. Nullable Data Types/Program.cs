using System;

namespace _13.Nullable_Data_Types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare a nullable int using Nullable<T>
            Nullable<int> nullableInt1 = null;

            // Shorthand notation using int?
            int? nullableInt2 = null;

            if (nullableInt1.HasValue)
                Console.WriteLine($"nullableInt1 has a value: {nullableInt1.Value}");
            else
                Console.WriteLine("nullableInt1 is null.");

            if (nullableInt2.HasValue)
                Console.WriteLine($"nullableInt1 has a value: {nullableInt2.Value}");
            else
                Console.WriteLine("nullableInt1 is null.");

            // Using the null-coalescing operator
            int result = nullableInt1 ?? 0;
            Console.WriteLine($"Using null-coalescing operator: {result}");

            string stringValue = nullableInt1?.ToString();
            Console.WriteLine($"String representation: {stringValue ?? null}");
        }
    }
}
