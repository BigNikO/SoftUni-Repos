using System;
using System.Linq;

namespace Ex6TargetPractice
{
    class TargetPractice
    {
        static void Main(string[] args)
        {
            int[] dimentions = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = dimentions[0];
            int cols = dimentions[1];
            String snake = Console.ReadLine();
            int[] shot = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int centerRows = shot[0];
            int centerCols = shot[1];
            int radius = shot[2];
            char[][] matrix = new char[rows][];

            BuildMatrix(matrix, rows, cols, snake);
            ShotMatrix(matrix, centerRows, centerCols, radius);
            FallCells(matrix);
            foreach (var row in matrix)
            {
                System.Console.WriteLine(String.Join("", row));
            }
        }
        public static void BuildMatrix(char[][] matrix, int rows, int cols, String snake)
        {

            for (int row = rows - 1; row >= 0; row--)
            {
                matrix[row] = new char[cols];
                Boolean isOdd = true;
                int col = isOdd ? cols - 1 : 0;
                int letter = 0;
                while (true)
                {
                    try
                    {
                        matrix[row][col] = snake[letter];
                        letter = letter + 1 == snake.Length ? 0 : letter + 1;
                        if (isOdd)
                        {
                            col--;
                        }
                        else
                        {
                            col++;
                        }
                    }
                    catch (Exception)
                    {
                        isOdd = !isOdd;
                        row--;
                        if (row < 0)
                        {
                            break;
                        }
                        matrix[row] = new char[cols];
                        if (isOdd)
                        {
                            col--;
                        }
                        else
                        {
                            col++;
                        }
                        matrix[row][col] = snake[letter];
                    }

                }
            }
        }
        public static void ShotMatrix(char[][] matrix, int centerX, int centerY, int radius)
        {
            for (int x = 0; x < matrix.Length; x++)
            {
                for (int y = 0; y < matrix[x].Length; y++)
                {
                    if ((x - centerX) * (x - centerX) + (y - centerY) * (y - centerY) <= radius * radius)
                    {
                        matrix[x][y] = " "[0];
                    }
                }
            }
        }
        public static void FallCells(char[][] matrix)
        {
            for (int col = 0; col < matrix[0].Length; col++) // Fall down all cells above the impact zone
            {
                for (int row = matrix.Length - 1; row > 0; row--)
                {
                    if (matrix[row][col] == ' ' && matrix[row - 1][col] != ' ')
                    {
                        while (row < matrix.Length)
                        {
                            if (matrix[row][col] == ' ')
                            {
                                var temp = matrix[row - 1][col];
                                matrix[row - 1][col] = matrix[row][col];
                                matrix[row][col] = temp;
                                row++;
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                }
            }
        }
    }
}
