using System;
using System.Linq;

namespace Ex11EqualSums
{
    class EqualSums
    {
        static void Main(string[] args)
        {
            int[] theArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < theArray.Length; i++)
            {
                int sumLeft = 0;
                int sumRight = 0;
                for (int left = 0; left < i; left++)
                {
                    sumLeft += theArray[left];
                }
                for (int right = i+1; right < theArray.Length; right++)
                {
                    sumRight += theArray[right];
                }
                if (sumLeft==sumRight)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
            Console.WriteLine("no");
        }
    }
}
