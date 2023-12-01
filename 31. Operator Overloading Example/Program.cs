using System;

namespace _31.Operator_Overloading_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point(1, 2);
            Point point2 = new Point(3, 4);

            // Using the overloaded + operator for point addition
            Point point3 = point1 + point2;

            // Using the overloaded + operator for point addition
            Point point4 = point1 - point2;

            Console.WriteLine($"Point1 : {point1.ToString()}");
            Console.WriteLine($"Point2 : {point2.ToString()}");
            Console.WriteLine($"Point3 is the result of point1 + point2: {point3.ToString()}");
            Console.WriteLine($"Point4 is the result of point1 - point2: {point4.ToString()}");

            // Using the overloaded == operator for point equality
            if (point1 == point2)
                Console.WriteLine("Using == : Yes, Point1 = Point2");
            else
                Console.WriteLine("Using == : No, Piont1 does not equal Point2");

            // Using the overloaded != operator for point inequality
            if (point1 != point2)
                Console.WriteLine("Using != : Yes, Piont1 does not equal Point2");
            else
                Console.WriteLine("Using != : No, Piont1 = Point2");

            Console.ReadKey();
        }
    }

    class Point
    {
        public int x { get; set; }
        public int y { get; set; }

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        // Overriding ToString for better readability
        public override string ToString()
        {
            return $"({x} , {y})";
        }

        // Overloading the + operator for point addition
        public static Point operator + (Point left, Point right)
        {
            return new Point(left.x + right.x, left.y + right.y);
        }


        public static Point operator - (Point left, Point right)
        {
            return new Point(left.x - right.x, left.y - right.y);
        }

        // Overloading the == operator for fraction equality
        public static bool operator == (Point left, Point right)
        {
            return ((left.x == right.x) && (left.y == right.y));
        }

        // Overloading the != operator for fraction equality
        public static bool operator != (Point left, Point right)
        {
            return ((left.x != right.y) || (left.y != right.y));
        }
    }
}
