using System;

namespace Ex5BMPCounter
{
    class BMPCounter
    {
        static void Main(string[] args)
        {
            double beatsPerMinute = double.Parse(Console.ReadLine());
            double beats = double.Parse(Console.ReadLine());
            double bars = Math.Round(beats / 4.0, 1);
            int minutes = (int)(beats / beatsPerMinute);
            int seconds = (int)(((beats / beatsPerMinute) - minutes) * 60.0);
            Console.WriteLine($"{bars} bars - {minutes}m {seconds}s");
        }
    }
}
