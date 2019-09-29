using System;

namespace Ex3MegaPixels
{
    class MegaPixels
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine($"{width}x{height} => {Math.Round(width*height/1000000.00,1)}MP");
        }
    }
}
