using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex4BasicQueueOperations
{
    class BasicQueueOperations
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int elementsToEnqueue = input[0];
            int elementsToDequeue = input[1];
            int checkNumber = input[2];
            if (elementsToDequeue == elementsToEnqueue)
            {
                Console.WriteLine(0);
            }
            else
            {
                Queue<int> queue = new Queue<int>(Console.ReadLine().Split(' ').Select(int.Parse));
                for (int i = 0; i < elementsToDequeue; i++)
                {
                    queue.Dequeue();
                }
                if (queue.Contains(checkNumber))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(queue.Min());
                }

            }
        }
    }
}
