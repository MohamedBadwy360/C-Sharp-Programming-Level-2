using System;


namespace _20._Type__Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Type type = typeof(string);

            Console.WriteLine("Type Information");
            Console.WriteLine($"Name : {type.Name}");
            Console.WriteLine($"Full Name : {type.FullName}");
            Console.WriteLine($"Is Class? : {type.IsClass}");
        }
    }
}
