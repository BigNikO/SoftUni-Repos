using System;
using System.Linq;

namespace Lab4TripleSum
{
    class TripleSum
    {
        static void Main(string[] args)
        {

            int[] myArray = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var check = false;
            for (int i = 0; i < myArray.Length - 1; i++)
            {
                for (int j = i + 1; j < myArray.Length; j++)
                {
                    if (myArray.Contains(myArray[i] + myArray[j])&& (myArray[i] + myArray[j])!=0)
                    {
                        Console.WriteLine($"{myArray[i]} + {myArray[j]} == {myArray[i] + myArray[j]}");
                        check = true;
                    }
                }
            }
            if (!check)
            {
                Console.WriteLine("No");
            }
        }
    }
}
