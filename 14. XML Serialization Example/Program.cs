using System;
using System.IO;
using System.Xml.Serialization;

namespace _14.XML_Serialization_Example
{
    [Serializable]
    public class Person
    {
        public string Name { get; set; }
        public byte Age { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person { Name = "Mohamed Badwy", Age = 23 };

            XmlSerializer serilizer = new XmlSerializer(typeof(Person));

            // XML serialization
            using (TextWriter writer = new StreamWriter("person.xml"))
            {
                serilizer.Serialize(writer, person);
            }

            // Deserialize the object back
            using (TextReader reader = new StreamReader("person.xml"))
            {
                Person deserilizedPerson = (Person)serilizer.Deserialize(reader);
                Console.WriteLine($"Name : {deserilizedPerson.Name} , Age : {deserilizedPerson.Age}");
            }
        }
    }
}
