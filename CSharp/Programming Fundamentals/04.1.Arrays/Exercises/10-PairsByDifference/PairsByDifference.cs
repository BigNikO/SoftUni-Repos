using System;
using System.Linq;

namespace Ex10PairsByDifference
{
    class PairsByDifference
    {
        static void Main(string[] args)
        {

            int[] pairArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int difference = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int i = 0; i < pairArray.Length; i++)
            {
                for (int j = i; j < pairArray.Length; j++)
                {
                    if ((Math.Max(pairArray[i],pairArray[j])- Math.Min(pairArray[i], pairArray[j])==difference))
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
