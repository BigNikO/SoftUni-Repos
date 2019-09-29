using System;

namespace Ex8CenterPoint
{
    class CenterPoint
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            ClosestPoint(x1, x2, x3, x4);
        }
        static void ClosestPoint(double x1, double x2, double x3, double x4)
        {
            if (x1*x1+x2*x2<=x3*x3+x4*x4)
            {
                Console.WriteLine($"({x1}, {x2})");
            }
            else
            {
                Console.WriteLine($"({x3}, {x4})");

            }
        }
    }
}
