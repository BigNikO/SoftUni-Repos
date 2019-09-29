using System;
using System.Linq;

namespace Ex3SquaresInMatrix
{
    class SquaresInMatrix
    {
        static void Main (string[] args)
        {
            int[] sizes = Console.ReadLine ().Split (' ', StringSplitOptions.RemoveEmptyEntries).Select (int.Parse).ToArray ();
            int rows = sizes[0];
            int cols = sizes[1];
            char[, ] matrix = new char[rows, cols];
            int counter = 0;

            for (int row = 0; row < rows; row++)
            {
                char[] rowElements = Console.ReadLine ().Split (' ', StringSplitOptions.RemoveEmptyEntries).Select (char.Parse).ToArray ();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = rowElements[col];
                }
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    try
                    {
                        if (matrix[row, col] == matrix[row + 1, col + 1] && matrix[row, col] == matrix[row, col + 1] &&
                            matrix[row + 1, col] == matrix[row, col])
                        {
                            counter++;
                        }
                    }
                    catch (Exception) { }
                }
            }

            Console.WriteLine (counter);
        }
    }
}