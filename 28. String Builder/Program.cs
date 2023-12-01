using System;
using System.Diagnostics;
using System.Text;

namespace _28.String_Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int iterations = 200000;

            Stopwatch stopwatch = Stopwatch.StartNew();
            ConcatenationString(iterations);
            stopwatch.Stop();
            Console.WriteLine($"String Concatenation using + took {stopwatch.ElapsedMilliseconds}");

            Stopwatch stopwatch2 = Stopwatch.StartNew();
            ConcatenationStringBuilder(iterations);
            stopwatch2.Stop();
            Console.WriteLine($"String Concatenation using StringBuilder took {stopwatch2.ElapsedMilliseconds}");
        }
        
        static void ConcatenationString(int iterations)
        {
            string result = "";
            for (int i = 0; i < iterations; i++)
            {
                result += "a";
            }
        }

        static void ConcatenationStringBuilder(int iterations)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < iterations; i++)
            {
                sb.Append("a");
            }

            string result = sb.ToString();
        }
    }
}
