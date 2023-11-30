using System;


namespace _19.Obsolete_Attribute
{
    public class MyClass
    {
        [Obsolete("This method will be deprecated in the future")]
        public void method1()
        {

        }
        public void method2() { }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();

            myClass.method1();

            myClass.method2();
        }
    }
}
