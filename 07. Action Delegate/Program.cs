using System;

namespace _07.Action_Delegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action parameterlessAction = ParameterlessMethod;
            Action<int> intParameterAction = IntParameterMethod;
            Action<int, string> multipleParametersAction = MultipleParametersMethod;

            parameterlessAction();
            intParameterAction(5);
            multipleParametersAction(6, "hello");
        }

        public static void ParameterlessMethod()
        {
            Console.WriteLine("ParameterlessMethod");
        }

        public static void IntParameterMethod(int x)
        {
            Console.WriteLine($"IntParameterMethod  => {x}");
        }

        public static void MultipleParametersMethod(int x, string message)
        {
            Console.WriteLine($"MultipleParametersMethod  => {x} => {message}");
        }
    }
}
