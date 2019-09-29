using System;
using System.Linq;
using System.Text;

namespace Ex5RubixMatrix
{
    class RubixMatrix
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();
            int[,] matrix = new int[dimensions[0], dimensions[1]];
            int currentValue = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    currentValue = currentValue + 1;
                    matrix[row, col] = currentValue;
                }
            }
            int moves = int.Parse(Console.ReadLine());
            Move(matrix, moves);
            Swap(matrix);
        }
        public static void Move(int[,] matrix, int moves)
        {
            string[] command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int place = int.Parse(command[0]);
            string direction = command[1].ToLower();
            int rotations = int.Parse(command[2]);
            moves--;
            switch (direction)
            {
                case "up":
                    Up(matrix, place, rotations % matrix.GetLength(0)); break;
                case "down":
                    Down(matrix, place, rotations % matrix.GetLength(0)); break;
                case "right":
                    Right(matrix, place, rotations % matrix.GetLength(1)); break;
                case "left":
                    Left(matrix, place, rotations % matrix.GetLength(1)); break;
                default:
                    break;
            }
            if (moves == 0)
            {
                return;
            }
            Move(matrix, moves);
        }
        public static void Up(int[,] matrix, int col, int moves)
        {

            for (int i = 0; i < moves; i++)
            {
                int firstElement = matrix[0, col];
                int lastElement = matrix[matrix.GetLength(0) - 1, col];
                for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
                {
                    if (row == 0)
                    {
                        matrix[matrix.GetLength(0) - 1, col] = firstElement;
                    }
                    else
                    {
                        int previousElement = matrix[row - 1, col];
                        matrix[row - 1, col] = lastElement;
                        lastElement = previousElement;
                    }
                }
            }
        }
        public static void Down(int[,] matrix, int col, int moves)
        {

            for (int i = 0; i < moves; i++)
            {
                int firstElement = matrix[0, col];
                int lastElement = matrix[matrix.GetLength(0) - 1, col];
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    if (row == matrix.GetLength(0) - 1)
                    {
                        matrix[0, col] = lastElement;
                    }
                    else
                    {
                        int nextElement = matrix[row + 1, col];
                        matrix[row + 1, col] = firstElement;
                        firstElement = nextElement;
                    }
                }
            }
        }
        public static void Left(int[,] matrix, int row, int moves)
        {

            for (int i = 0; i < moves; i++)
            {
                int firstElement = matrix[row, 0];
                int lastElement = matrix[row, matrix.GetLength(1) - 1];
                for (int col = matrix.GetLength(1) - 1; col >= 0; col--)
                {
                    if (col == 0)
                    {
                        matrix[row, matrix.GetLength(1) - 1] = firstElement;
                    }
                    else
                    {
                        int previousElement = matrix[row, col - 1];
                        matrix[row, col - 1] = lastElement;
                        lastElement = previousElement;
                    }
                }
            }
        }
        public static void Right(int[,] matrix, int row, int moves)
        {

            for (int i = 0; i < moves; i++)
            {
                int firstElement = matrix[row, 0];
                int lastElement = matrix[row, matrix.GetLength(1) - 1];
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (col == matrix.GetLength(1) - 1)
                    {
                        matrix[row, 0] = lastElement;
                    }
                    else
                    {
                        int nextElement = matrix[row, col + 1];
                        matrix[row, col + 1] = firstElement;
                        firstElement = nextElement;
                    }
                }

            }
        }
        public static void Swap(int[,] matrix)
        {
            StringBuilder sb = new StringBuilder();
            int expectedValue = 1;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == expectedValue)
                    {
                        sb.Append($"No swap required{Environment.NewLine}");
                    }
                    else
                    {
                        for (int i = row; i < matrix.GetLength(0); i++)
                        {
                            for (int j = i == row ? col : 0; j < matrix.GetLength(1); j++)
                            {
                                if (matrix[i, j] == expectedValue)
                                {
                                    sb.Append($"Swap ({row}, {col}) with ({i}, {j}){Environment.NewLine}");
                                    int temp = matrix[i, j];
                                    matrix[i, j] = matrix[row, col];
                                    matrix[row, col] = temp;
                                }
                            }
                        }
                    }
                    expectedValue++;
                }
            }
            Console.Write(sb.ToString());
        }
    }
}