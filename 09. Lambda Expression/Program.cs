using System;


namespace _09.Lambda_Expression
{

    internal class Program
    {
        public static Func<int, int> square = (x) => x * x;

        public static Action parameterlessAction = () =>
            {
                Console.WriteLine("This is parameterless Action.\n");
            };

        public static Action<int> intParameterAction = (x) =>
            {
                Console.WriteLine($"Action with int parameter {x}\n");
            };

        public static Action<int, string> intStringPrameterAction = (x, y) =>
            {
                Console.WriteLine($"Action with int parameter {x} and string parameter {y}\n");
            };

        public delegate int Operation(int x, int y);

        public static void ExecuteOperation(int x, int y, Operation operation) 
        {
            int result = operation(x, y);
            Console.WriteLine($"Result = {result}");
        }
        static void Main(string[] args)
        {
            int result = square(5);
            Console.WriteLine($"Result = {result}\n");

            parameterlessAction();
            intParameterAction(5);
            intStringPrameterAction(5, "hello");

            ExecuteOperation(10, 20, (int x, int y) => x + y);
            ExecuteOperation(10, 20, (int x, int y) => x - y);
        }
    }
}
