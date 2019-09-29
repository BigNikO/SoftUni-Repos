using System;

namespace Exe12BeerKeys
{
    class Program
    {
        static void Main(string[] args)
        {
            int countKegs = int.Parse(Console.ReadLine());
            string bigKegModel = "";
            double maxVolume = 0.0;
            for (int i = 0; i < countKegs; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                double volume = Math.PI * radius * radius * height;
                if (maxVolume<volume)
                {
                    maxVolume = volume;
                    bigKegModel = model;
                }
            }
            Console.WriteLine(bigKegModel);
        }
    }
}
