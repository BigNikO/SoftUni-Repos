using System;

namespace Lab6CalculateTriangleArea
{
    class CalculateTriangleArea
    {
        static void Main(string[] args)
        {
            double side = ReadLine();
            double height = ReadLine();
            Console.WriteLine(PrintArea(side,height));
        }
        static double PrintArea(double side, double height)
        {
            double area = side * height/2;
            return area;
        }
        static double ReadLine()
        {
            double value = double.Parse(Console.ReadLine());
            return value;
        }

    }
}
