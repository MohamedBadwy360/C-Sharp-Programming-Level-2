using System;


namespace _17.Serialization_Attributes
{
    internal class Program
    {
        [Serializable]
        class MyClass
        {
            // Will be Serialized
            public int SerializedField;

            // Will not be serialized
            [NonSerialized]
            public int NonSerializedField;
        }
        static void Main(string[] args)
        {

        }
    }
}
