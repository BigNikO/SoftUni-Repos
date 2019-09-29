using System;

namespace Ex3WaterOverflow
{
    class WaterOverflow
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int water = 0;
            for (int i = 0; i < n; i++)
            {
                int currentWater = int.Parse(Console.ReadLine());
                if (!(currentWater+water>255))
                {
                    water += currentWater;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }
            Console.WriteLine(water);
        }
    }
}
