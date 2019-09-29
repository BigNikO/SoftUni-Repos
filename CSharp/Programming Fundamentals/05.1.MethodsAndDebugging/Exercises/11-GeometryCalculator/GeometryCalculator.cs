using System;

namespace Exe11GeometryCalculator
{
    class GeometryCalculator
    {
        static void Main(string[] args)
        {
            string figure= Console.ReadLine();
            Console.WriteLine($"{CalculatorArea(figure):f2}");
        }
        static double CalculatorArea(string figure)
        {
            double result = 0;
            switch (figure)
            {
                case "triangle":
                    {
                        double side = double.Parse(Console.ReadLine());
                        double height = double.Parse(Console.ReadLine());
                        result = side * height / 2;
                    }
                    break;
                case "rectangle":
                    {
                        double width = double.Parse(Console.ReadLine());
                        double height = double.Parse(Console.ReadLine());
                        result = height*width;
                    }
                    break;
                case "square":
                    {
                        double side = double.Parse(Console.ReadLine());
                        result = side * side;
                    }
                    break;
                case "circle":
                    {
                        double radius = double.Parse(Console.ReadLine());
                        result = Math.PI * radius * radius;
                    }
                    break;
                default:
                    break;
            }
            return result;
        }
    }
}
