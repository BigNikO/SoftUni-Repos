using System;

namespace Exe10CubeProperties
{
    class CubeProperties
    {
        static void Main(string[] args)
        {
            double side =double.Parse(Console.ReadLine());
            string property = Console.ReadLine();
            Console.WriteLine($"{TheCubeProperties(side, property):f2}");
        }
        static double TheCubeProperties(double side, string property)
        {
            double result = 0;
            switch (property)
            {
                case ("area"):
                    {
                        result = side * side * 6;
                    }
                    break;
                case ("volume"):
                    {
                        result = side * side * side;
                    }
                    break;
                case ("face"):
                    {
                        result = side * Math.Sqrt(2);
                    }
                    break;
                case ("space"):
                    {
                        result = side * Math.Sqrt(3);
                    }
                    break;
            }
            return result;
        }
    }
}
