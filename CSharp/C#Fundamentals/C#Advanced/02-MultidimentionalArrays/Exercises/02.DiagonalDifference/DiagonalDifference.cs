using System;
using System.Linq;

namespace Ex2DiagonalDifference
{
    class DiagonalDifference
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size, size];

            int primaryDiagonalSum = 0;
            int secondaryDiagonalSum = 0;

            for (int i = 0; i < size; i++)
            {
                int[] rowElements = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();
                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = rowElements[j];
                }
            }

            for (int i = 0; i < size; i++)
            {
                int primarySum = matrix[i, i];
                int secondarySum = matrix[i, size - i - 1];
                primaryDiagonalSum += primarySum;
                secondaryDiagonalSum += secondarySum;
            }

            Console.WriteLine(Math.Abs(primaryDiagonalSum - secondaryDiagonalSum));
        }
    }
}