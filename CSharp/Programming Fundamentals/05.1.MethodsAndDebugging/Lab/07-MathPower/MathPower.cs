using System;

namespace Lab7MathPower
{
    class MathPower
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            double newNumber = MathPowerMethod(number, power);
            Console.WriteLine(newNumber);
        }
        static double MathPowerMethod(double number, int power)
        {
            double result = 1d;
            for (int i = 1; i <= power; i++)
            {
                result *= number;
            }
            return result;
        }
    }
}
