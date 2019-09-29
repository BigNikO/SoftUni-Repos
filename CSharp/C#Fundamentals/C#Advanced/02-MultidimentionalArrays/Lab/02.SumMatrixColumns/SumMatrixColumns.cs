using System;
using System.Linq;

namespace Lab2SymMatrixColumns
{
    class SumMatrixColumns
    {
        static void Main (string[] args)
        {
            System.Console.WriteLine ("Second Problem");
            int[] rowsAndCols = Console.ReadLine ().Split (", ").Select (int.Parse).ToArray ();

            int rows = rowsAndCols[0];
            int cols = rowsAndCols[1];

            int[, ] matrix = new int[rows, cols];

            for (int row = 0; row < matrix.GetLength (0); row++)
            {
                int[] colElements = Console.ReadLine ().Split ().Select (int.Parse).ToArray ();

                for (int col = 0; col < matrix.GetLength (1); col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }

            for (int col = 0; col < matrix.GetLength (1); col++)
            {
                int sum = 0;
                for (int row = 0; row < matrix.GetLength (0); row++)
                {
                    sum += matrix[row, col];
                }

                Console.WriteLine (sum);
            }
        }
    }
}