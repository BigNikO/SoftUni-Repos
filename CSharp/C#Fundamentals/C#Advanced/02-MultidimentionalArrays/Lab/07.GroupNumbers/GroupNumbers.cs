using System;
using System.Linq;

namespace Lab7GroupNumbers
{
    class GroupNumbers
    {
        static void Main (string[] args)
        {
            int rows = 3;
            int[][] outputArray = new int[rows][];

            int[] inputLine = Console.ReadLine ().Split (", ", StringSplitOptions.RemoveEmptyEntries).Select (int.Parse).ToArray ();

            outputArray[0] = inputLine.Where (x => Math.Abs (x) % 3 == 0).ToArray ();
            outputArray[1] = inputLine.Where (x => Math.Abs (x) % 3 == 1).ToArray ();
            outputArray[2] = inputLine.Where (x => Math.Abs (x) % 3 == 2).ToArray ();
            foreach (var row in outputArray)
            {
                Console.WriteLine (String.Join (" ", row));
            }
        }
    }
}