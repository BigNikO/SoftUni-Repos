using System;
using System.Collections.Generic;
using System.Linq;

namespace CupsAndBottles
{
    class StartUp
    {
        static void Main(string[] args)
        {

            Queue<int> cups = new Queue<int>(Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            Stack<int> bottles = new Stack<int>(Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            int currentQuantity = 0;
            int wastedWater = 0;
            while (bottles.Count > 0)
            {
                if (cups.Count > 0)
                {
                    if (bottles.Peek() + currentQuantity >= cups.Peek())
                    {
                        wastedWater += bottles.Pop() + currentQuantity - cups.Dequeue();
                        currentQuantity = 0;
                    }
                    else
                    {
                        currentQuantity += bottles.Pop();
                    }
                }
                else
                {
                    Console.WriteLine("Bottles: " + String.Join(" ",bottles));
                    Console.WriteLine($"Wasted litters of water: { wastedWater}");
                    return;
                }
            }
            if (cups.Count > 0)
            {
                Console.WriteLine("Cups: " + String.Join(" ", cups));
                Console.WriteLine($"Wasted litters of water: { wastedWater}");
            }
        }
    }
}
