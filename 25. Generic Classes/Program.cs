using System;


namespace _25.Generic_Classes
{
    public class GenericBox<T>
    {
        private T _content;

        public GenericBox(T content)
        {
            _content = content;
        }

        public T BoxContent() => _content;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            GenericBox<int> intBox = new GenericBox<int>(23);
            Console.WriteLine($"Content of intContent = {intBox.BoxContent()}");

            GenericBox<string> stringBox = new GenericBox<string>("Mohamed");
            Console.WriteLine($"Content of stringBox = {stringBox.BoxContent()}");

        }
    }
}
