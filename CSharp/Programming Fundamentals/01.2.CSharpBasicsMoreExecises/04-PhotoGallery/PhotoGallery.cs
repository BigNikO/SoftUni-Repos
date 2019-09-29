using System;

namespace Ex4PhotoGallery
{
    class PhotoGallery
    {
        static void Main(string[] args)
        {
            int numberOfThePhoto = int.Parse(Console.ReadLine());
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int size = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            Console.WriteLine($"Name: DSC_{numberOfThePhoto:d4}.jpg");
            Console.WriteLine($"Date Taken: {day:d2}/{month:d2}/{year} {hours:d2}:{minutes:d2}");
            if (size<1000)
            {
                Console.WriteLine($"Size: {size}B");
            }
            else if (size<1000000)
            {
                Console.WriteLine($"Size: {Math.Round((double)size/(double)1000,1)}KB");
            }
            else
            {
                Console.WriteLine($"Size: {Math.Round((double)size / (double)1000000, 1)}MB");
            }
            if (width>height)
            {
                Console.WriteLine($"Resolution: {width}x{height} (landscape)");
            }
            else if (width==height)
            {
                Console.WriteLine($"Resolution: {width}x{height} (square)");
            }
            else
            {
                Console.WriteLine($"Resolution: {width}x{height} (portrait)");

            }

        }
    }
}
