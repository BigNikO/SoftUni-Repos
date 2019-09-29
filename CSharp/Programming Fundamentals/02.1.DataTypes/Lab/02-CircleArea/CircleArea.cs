using System;

namespace Lab2CircleArea
{
    class CircleArea
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());
            Console.WriteLine($"{r*r*Math.PI:f12}");
        }
    }
}
