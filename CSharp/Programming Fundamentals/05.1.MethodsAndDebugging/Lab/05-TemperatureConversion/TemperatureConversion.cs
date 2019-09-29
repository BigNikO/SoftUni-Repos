using System;

namespace Lab5TemperatureConversion
{
    class TemperatureConversion
    {
        static void Main(string[] args)
        {
            double fahrenheit = double.Parse(Console.ReadLine());
            double celsius = CheckFarenheit(fahrenheit);
            Console.WriteLine($"{celsius:f2}");
        }
        static double CheckFarenheit(double fahrenheit)
        {
            double celsius = (fahrenheit - 32) * 5 / 9d;
            return celsius;
        }
    }
}
