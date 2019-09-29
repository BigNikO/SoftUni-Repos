using System;
using System.Linq;

namespace Lab1SumMatrixElements
{
    class SumMatrixElements
    {
        static void Main (string[] args)
        {
            var rowsAndCols = Console.ReadLine ().Split (", ").Select (int.Parse).ToArray ();

            int rows = rowsAndCols[0];
            int cols = rowsAndCols[1];

            int[, ] matrix = new int[rows, cols];

            for (int row = 0; row < matrix.GetLength (0); row++)
            {
                int[] colElements = Console.ReadLine ().Split (", ").Select (int.Parse).ToArray ();

                for (int col = 0; col < matrix.GetLength (1); col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }

            int sum = 0;

            for (int row = 0; row < matrix.GetLength (0); row++)
            {
                for (int col = 0; col < matrix.GetLength (1); col++)
                {
                    sum += matrix[row, col];
                }
            }

            Console.WriteLine (rows);
            Console.WriteLine (cols);
            Console.WriteLine (sum);
        }
    }
}