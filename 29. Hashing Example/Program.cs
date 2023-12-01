using System;
using System.Security.Cryptography;
using System.Text;


namespace _29.Hashing_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input data
            string data = "Mohamed Badwy";

            // Compute the SHA-256 hash of the input data
            string hashedData = ComputeHash(data);

            // Display the original data and its hash
            Console.WriteLine(data);
            Console.WriteLine(hashedData);

            Console.WriteLine($"Hashed Data length : {hashedData.Length}");
        }

        static string ComputeHash(string input)
        {
            //SHA is Secutred Hash Algorithm.
            // Create an instance of the SHA-256 algorithm
            using(SHA256 sha256 = SHA256.Create())
            {
                // Compute the hash value from the UTF-8 encoded input string
                byte[] hashbytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));
                return BitConverter.ToString(hashbytes).Replace("-", "").ToLower();
            }
        }
    }
}
