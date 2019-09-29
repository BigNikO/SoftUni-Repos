using System;
using System.Linq;

namespace Lab5SquareWithMatrixSum
{
    class SquareWithMatrixSum
    {
        static void Main (string[] args)
        {
            int[] rowsAndCols = Console.ReadLine ().Split (", ").Select (int.Parse).ToArray ();
            int rows = rowsAndCols[0];
            int cols = rowsAndCols[1];
            int[, ] matrix = new int[rows, cols];
            int[, ] resultMatrix = new int[2, 2];
            int sum = 0;
            for (int row = 0; row < rows; row++)
            {
                int[] colElements = Console.ReadLine ().Split (", ").Select (int.Parse).ToArray ();

                for (int col = 0; col < matrix.GetLength (1); col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (row < rows - 1 && col < cols - 1)
                    {
                        int currentSum = matrix[row, col] + matrix[row + 1, col] + matrix[row, col + 1] +
                            matrix[row + 1, col + 1];
                        if (currentSum > sum)
                        {
                            resultMatrix[0, 0] = matrix[row, col];
                            resultMatrix[0, 1] = matrix[row, col + 1];
                            resultMatrix[1, 0] = matrix[row + 1, col];
                            resultMatrix[1, 1] = matrix[row + 1, col + 1];
                            sum = currentSum;
                        }

                    }
                }
            }

            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    Console.Write (resultMatrix[row, col] + " ");

                }
                Console.WriteLine ();
            }

            Console.WriteLine (sum);

        }
    }
}