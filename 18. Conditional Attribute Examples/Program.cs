// #define DEBUG
#define TraceEnabled

using System;
using System.Data.SqlTypes;
using System.Diagnostics;


namespace _18.Conditional_Attribute_Examples
{
    internal class Program
    {
        public class MyClass
        {
            [Conditional("BEBUG")]
            public void DebugMethod()
            {
                Console.WriteLine("Debug Method Called");
            }

            public void NormalMethod()
            {
                Console.WriteLine("Normal Method called");
            }
        }

        [Conditional("TraceEnabled")]
        public static void Log(string message)
        {
            Console.WriteLine($"[Trace] {message}");
        }

        [Conditional("DEBUG")]
        public static void hello()
        {
            Console.WriteLine("Hello Debug Mode");
        }
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();

            myClass.DebugMethod();   // This will only be executed in DEBUG builds
            myClass.NormalMethod(); // This will always be executed

            Log("Trace Message");
            hello();
            Console.ReadKey();
        }
    }
}
