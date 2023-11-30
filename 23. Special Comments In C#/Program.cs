using System;


namespace _23.Special_Comments_In_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2));
        }
    }

    /// <summary>
    /// This class represents a simple calculator.
    /// </summary>
    public class Calculator
    {
        /// <summary>
        /// Adds two numbers and returns the result.
        /// </summary>
        /// <param name="a">The first number to be added.</param>
        /// <param name="b">The second number to be added.</param>
        /// <returns>The sum of the two numbers</returns>
        public int Add(int a, int b) => a + b;
    }
}
