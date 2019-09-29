using System;

namespace Exe11ConverSpeedUnis
{
    class ConverSpeedUnis
    {
        static void Main(string[] args)
        {
            double distance = double.Parse(Console.ReadLine());
            double hours = double.Parse(Console.ReadLine());
            double minutes = double.Parse(Console.ReadLine());
            double seconds = double.Parse(Console.ReadLine());
            double realHours = hours + minutes/60 + seconds/3600;
            double realseconds = hours * 3600 + minutes * 60 + seconds;
            double metrePersecond = distance / realseconds;
            double kilometersPerHour = distance / 1000 / realHours;
            double milesPerHour = (distance / 1000) / 1.609 / realHours;
            Console.WriteLine($"{metrePersecond:f6}");
            Console.WriteLine($"{kilometersPerHour:f6}");
            Console.WriteLine($"{milesPerHour:f6}");
        }
    }
}
