using System;

namespace Exe19TheaThePhotographer
{
    class ТheaThePhotographer
    {
        static void Main(string[] args)
        {
            long days, hours, minutes, seconds = 0;
            long numberOfPictures = int.Parse(Console.ReadLine());
            long filterTime = int.Parse(Console.ReadLine());
            long goodPicturesPercent = int.Parse(Console.ReadLine());
            long uploadtime = int.Parse(Console.ReadLine());
            long filteredPictures = (int)(Math.Ceiling(numberOfPictures * goodPicturesPercent / 100d));
            long totalTime = numberOfPictures * filterTime + filteredPictures * uploadtime;
            seconds = totalTime % 60;
            totalTime = (totalTime - seconds) / 60;
            minutes = totalTime % 60;
            totalTime = (totalTime - minutes) / 60;
            hours = totalTime % 24;
            days = (totalTime - hours) / 24;
            Console.WriteLine($"{days:d1}:{hours:d2}:{minutes:d2}:{seconds:d2}");
        }
    }
}
