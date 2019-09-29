using System;

namespace Lab8ReactorVolumeOfPyramid
{
    class ReactorVolumeOfPyramid
    {
        static void Main(string[] args)
        {
            Console.Write("Length: ");
            double pyramidLenght = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            double PyramidWidth = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            double pyramindHeight = double.Parse(Console.ReadLine());
            double volume = (pyramidLenght * PyramidWidth * pyramindHeight) / 3;
            Console.WriteLine("Pyramid Volume: {0:F2}", volume);

        }
    }
}
