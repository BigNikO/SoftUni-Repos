using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex6TruckTour
{
    class TruckTour
    {
        static void Main(string[] args)
        {
            int index = 0;
            int fuel = -1;
            int numberOfPumps = int.Parse(Console.ReadLine());
            Queue<int[]> pumps = new Queue<int[]>();
            for (int i = 0; i < numberOfPumps; i++)
            {
                pumps.Enqueue(Console.ReadLine().Split().Select(int.Parse).ToArray());
            }
            while (fuel < 0)
            {
                fuel = 0;
                foreach (var pump in pumps)
                {
                    int currentFuel = pump[0];
                    int distance = pump[1];
                    fuel += currentFuel - distance;
                    if (fuel < 0)
                    {
                        int[] changeStartPump = pumps.Dequeue();
                        pumps.Enqueue(changeStartPump);
                        index++;
                        break;
                    }
                } 
            }
            Console.WriteLine(index);
        }
    }
}
