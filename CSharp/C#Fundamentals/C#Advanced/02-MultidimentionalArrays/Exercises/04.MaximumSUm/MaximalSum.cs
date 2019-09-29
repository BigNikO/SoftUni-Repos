using System;
using System.Linq;

namespace Ex4MaximalSum
{
    class MaximalSum
    {
        static void Main(string[] args)
        {
            int[] rowsAndCols = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = rowsAndCols[0];
            int cols = rowsAndCols[1];
            int[,] matrix = new int[rows, cols];
            int[,] resultMatrix = new int[3, 3];
            int sum = 0;
            for (int row = 0; row < rows; row++)
            {
                int[] colElements = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    try
                    {
                        int currentSum = matrix[row, col] + matrix[row + 1, col] + matrix[row, col + 1] +
                            matrix[row + 1, col + 1] + matrix[row + 2, col] + matrix[row, col + 2] +
                            matrix[row + 2, col + 2] + matrix[row + 2, col + 1] + matrix[row + 1, col + 2];

                        if (currentSum > sum)
                        {
                            resultMatrix[0, 0] = matrix[row, col];
                            resultMatrix[0, 1] = matrix[row, col + 1];
                            resultMatrix[1, 0] = matrix[row + 1, col];
                            resultMatrix[1, 1] = matrix[row + 1, col + 1];
                            resultMatrix[1, 2] = matrix[row + 1, col + 2];
                            resultMatrix[2, 1] = matrix[row + 2, col + 1];
                            resultMatrix[0, 2] = matrix[row, col + 2];
                            resultMatrix[2, 0] = matrix[row + 2, col];
                            resultMatrix[2, 2] = matrix[row + 2, col + 2];
                            sum = currentSum;
                        }
                    }
                    catch (Exception) { }
                }
            }
            Console.WriteLine($"Sum = {sum}");

            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Console.Write(resultMatrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}