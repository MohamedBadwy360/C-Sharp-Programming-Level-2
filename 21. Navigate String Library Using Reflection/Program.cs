using System;
using System.Linq;
using System.Reflection;

namespace _21.Navigate_String_Library_Using_Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Get the assembly containing the System.String type 
            Assembly assembly = typeof(string).Assembly;

            // Get the System.String type
            Type stringType = assembly.GetType("System.String");

            if(stringType != null) 
            {
                Console.WriteLine($"Methods of the System.String class:\n");

                // Get all public methods of the System.String class

                var stringMethods = stringType.GetMethods(BindingFlags.Public | BindingFlags.Instance)
                    .OrderBy(method => method.Name);

                foreach(var method in stringMethods)
                {
                    Console.WriteLine($"\t{method.ReturnType} {method.Name}({GetParameterList(method.GetParameters())})");
                }
            }
            else
            {
                Console.WriteLine("System.String type not found.");
            }
        }

        static string GetParameterList(ParameterInfo[] parameters)
        {
            return string.Join(", ", parameters.Select(parameter => $"{parameter.ParameterType} {parameter.Name}"));
        }
    }
}
