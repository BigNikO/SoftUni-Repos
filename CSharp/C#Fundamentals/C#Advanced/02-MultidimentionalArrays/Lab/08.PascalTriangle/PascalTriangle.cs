using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab8PascalTriangle
{
    class PascalTriangle
    {
        static void Main (string[] args)
        {
            int rows = int.Parse (Console.ReadLine ());
            long[][] pascalTriangle = new long[rows][];

            pascalTriangle[0] = new long[1] { 1 };

            for (int i = 1; i < rows; i++)
            {
                long[] previousRow = pascalTriangle[i - 1];
                long[] nextRow = previousRow.Select (selector: (x, index) =>
                {
                    if (index + 1 < previousRow.Length)
                    {
                        return x + previousRow[index + 1];
                    }
                    return 0;
                }).ToArray ();

                List<long> currentRow = new List<long> { 1 };
                foreach (var number in nextRow)
                {
                    if (number > 0)
                    {
                        currentRow.Add (number);
                    }
                }
                currentRow.Add (1);
                pascalTriangle[i] = currentRow.ToArray ();
            }

            foreach (var row in pascalTriangle)
            {
                Console.WriteLine (String.Join (' ', row));
            }
        }
    }
}