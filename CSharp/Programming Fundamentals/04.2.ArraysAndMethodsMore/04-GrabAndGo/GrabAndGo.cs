using System;
using System.Linq;

namespace Ex4GrabAndGo
{
    class GrabAndGo
    {
        static void Main(string[] args)
        {
            int[] numbersArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int lastOccurence = int.Parse(Console.ReadLine());
            int count = 0;
            long sumArray = 0;
            for (int i = numbersArray.Length-1; i >= 0; i--)
            {
                if (numbersArray[i]==lastOccurence)
                {
                    count = i;
                    break;
                }
            }
            if (count==0)
            {
                Console.WriteLine("No occurrences were found!");
            }
            else
            {
                for (int i = 0; i < count; i++)
                {
                    sumArray += numbersArray[i];
                }
                Console.WriteLine(sumArray);
            }
        }
    }
}
