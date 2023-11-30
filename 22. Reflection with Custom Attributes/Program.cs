using System;
using System.Reflection;

namespace _23.Reflection_with_Custom_Attributes
{
    internal class Program
    {
        [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class, AllowMultiple = true)]
        public class MyCustomAttribute : Attribute
        {
            public string Description { get; }

            public MyCustomAttribute(string description)
            {
                Description = description;
            }
        }

        [MyCustom("This is a class Attribute")]
        public class MyClass
        {
            [MyCustom("This is a method Attribute")]
            public void MyMethod()
            {
                // Method implementation
            }
        }
        static void Main(string[] args)
        {
            // Get Type of MyClass
            Type type = typeof(MyClass);

            // Get class-level attributes
            object[] classAttributes = type.GetCustomAttributes(typeof(MyCustomAttribute), false);
            foreach(MyCustomAttribute attribute in classAttributes)
            {
                Console.WriteLine($"Class Attribute : {attribute.Description}");
            }

            // Get method-level attributes
            MethodInfo methodInfo = type.GetMethod("MyMethod");
            object[] methodAttributes = methodInfo.GetCustomAttributes(typeof(MyCustomAttribute), false);
            foreach(MyCustomAttribute attribute in methodAttributes)
            {
                Console.WriteLine($"Mrthod Attribute : {attribute.Description}");
            }
        }
    }
}
