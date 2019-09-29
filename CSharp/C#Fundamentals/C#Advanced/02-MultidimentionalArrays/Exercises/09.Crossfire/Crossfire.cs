using System.Linq;
using System;

namespace Ex9Crossfire
{
    class Crossfire
    {
        static int[][] matrix;
        static void Main(string[] args)
        {
            int[] dimentions = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = dimentions[0];
            int cols = dimentions[1];
            matrix = new int[rows][];

            BuildMatrix(cols);
            CommandNuke();
            PrintMatrix();
        }
        static void BuildMatrix(int cols)
        {
            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = new int[cols];
                for (int col = 0; col < cols; col++)
                {
                    matrix[row][col] = col + 1 + row * cols;
                }
            }
        }
        static void PrintMatrix()
        {
            for (int row = 0; row < matrix.Length; row++)
            {
                System.Console.WriteLine(String.Join(" ", matrix[row]));
            }
        }
        static void CrossFire(int row, int col, int radius)
        {
            for (int i = 0; i <= radius; i++)
            {
                if (IsInside(row + i, col))
                {
                    matrix[row + i][col] = -1;
                }
                if (IsInside(row - i, col))
                {
                    matrix[row - i][col] = -1;
                }
                if (IsInside(row, col + i))
                {
                    matrix[row][col + i] = -1;
                }
                if (IsInside(row, col - i))
                {
                    matrix[row][col - i] = -1;
                }
            }
        }
        static bool IsInside(int row, int col)
        {
            return row >= 0 && row < matrix.Length && col >= 0 && col < matrix[row].Length;
        }
        static void CommandNuke()
        {
            string command = Console.ReadLine();
            if (command == "Nuke it from orbit")
            {
                DestroyMatrix();
                return;
            }
            int[] strikeValues = command.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            CrossFire(strikeValues[0], strikeValues[1], strikeValues[2]);
            DestroyMatrix();
            CommandNuke();
        }
        static void DestroyMatrix()
        {
            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    if (matrix[row][col] < 0)
                    {
                        int[] currentRow = matrix[row].ToArray();
                        matrix[row] = currentRow.Where(x => x != -1).ToArray();
                        break;
                    }
                }
                if (matrix[row].Count() < 1)
                {
                    matrix = matrix.Take(row).Concat(matrix.Skip(row + 1)).ToArray();
                    row--;
                }
            }
        }
    }
}
