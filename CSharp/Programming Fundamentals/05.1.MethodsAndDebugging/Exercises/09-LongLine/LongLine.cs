using System;

namespace Ex9LongLine
{
    class LongLine
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());

            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());

            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            LongerLine(x1, y1, x2, y2, x3, y3, x4, y4);
        }
        static void LongerLine(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            double a = Math.Abs((x1) - (x2));
            double b = Math.Abs((y1) - (y2));
            double c = Math.Abs((x3) - (x4));
            double d = Math.Abs((y3) - (y4));
            if (a*a+b*b>=c*c+d*d)
            {
                ClosestPoint(x1, y1, x2, y2);
            }
            else
            {
                ClosestPoint(x3, y3, x4, y4);
            }
        }

        static void ClosestPoint(double x1, double x2, double x3, double x4)
        {
            if (x1 * x1 + x2 * x2 <= x3 * x3 + x4 * x4)
            {
                Console.Write($"({x1}, {x2})");
                Console.WriteLine($"({x3}, {x4})");
            }
            else
            {
                Console.Write($"({x3}, {x4})");
                Console.WriteLine($"({x1}, {x2})");

            }
        }
    }
}
