using System;

namespace Ex5WeatherForecast
{
    class WeatherForecast
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            long intNUmber = (long)(number);
            if (intNUmber!=number)
            {
                Console.WriteLine("Rainy");
            }
            else if (number>=sbyte.MinValue&&number<=sbyte.MaxValue)
            {
                Console.WriteLine("Sunny");
            }
            else if (number >= int.MinValue && number <= int.MaxValue)
            {
                Console.WriteLine("Cloudy");
            }
            else if (number >= long.MinValue && number <= long.MaxValue)
            {
                Console.WriteLine("Windy");
            }
        }
    }
}
