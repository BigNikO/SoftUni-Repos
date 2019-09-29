using System.Collections.Generic;
using System.Linq;
using System;

namespace Ex8RadioActiveMutant
{
    class RadioActiveMutant
    {

        static int playerRow;
        static int playerCol;
        static char[][] matrix;
        static bool isOutSide;
        static bool isDead;
        static void Main(string[] args)
        {
            int[] dimentions = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = dimentions[0];
            int cols = dimentions[1];
            matrix = new char[rows][];
            BuildMatrix();
            MovePlayer(Console.ReadLine().ToLower());
        }
        private static void MovePlayer(string directions)
        {

            for (int i = 0; i < directions.Length; i++)
            {
                char move = directions[i];
                switch (move)
                {
                    case 'u':
                        Move(-1, 0);
                        break;
                    case 'd':
                        Move(1, 0);
                        break;
                    case 'l':
                        Move(0, -1);
                        break;
                    default:
                        Move(0, 1);
                        break;
                }
                Spread();
                if (isOutSide)
                {
                    PrintMatrix();
                    System.Console.WriteLine($"won: {playerRow} {playerCol}");
                    break;
                }
                else if (isDead)
                {
                    PrintMatrix();
                    System.Console.WriteLine($"dead: {playerRow} {playerCol}");
                    break;
                }
            }

        }
        private static void Move(int row, int col)
        {
            int targetRow = playerRow + row;
            int targetCol = playerCol + col;
            if (!isInside(targetRow, targetCol))
            {
                isOutSide = true;
                matrix[playerRow][playerCol] = '.';
            }
            else if (IsBunny(targetRow, targetCol))
            {
                matrix[playerRow][playerCol] = '.';
                playerRow = targetRow;
                playerCol = targetCol;
                isDead = true;
            }
            else
            {
                matrix[playerRow][playerCol] = '.';
                matrix[targetRow][targetCol] = 'P';
                playerRow = targetRow;
                playerCol = targetCol;
            }

        }
        private static bool isInside(int row, int col)
        {
            return row >= 0 && row < matrix.Length && col >= 0 && col < matrix[row].Length;
        }
        private static bool IsBunny(int row, int col)
        {
            return matrix[row][col] == 'B';
        }
        static void BuildMatrix()
        {
            for (int row = 0; row < matrix.Length; row++)
            {
                char[] newRow = Console.ReadLine().ToCharArray();
                matrix[row] = newRow;
                for (int col = 0; col < newRow.Length; col++)
                {
                    if (matrix[row][col] == 'P')
                    {
                        playerRow = row;
                        playerCol = col;
                    }
                }
            }
        }
        static void PrintMatrix()
        {
            for (int row = 0; row < matrix.Length; row++)
            {
                System.Console.WriteLine(String.Join("", matrix[row]));
            }
        }
        static void Spread()
        {
            Queue<int[]> indexes = new Queue<int[]>();
            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    if (IsBunny(row, col))
                    {
                        indexes.Enqueue(new int[] { row, col });
                    }
                }
            }
            while (indexes.Count > 0)
            {
                int[] currentIndex = indexes.Dequeue();
                int targetRow = currentIndex[0];
                int targetCol = currentIndex[1];
                if (isInside(targetRow - 1, targetCol))
                {
                    if (matrix[targetRow - 1][targetCol] == 'P')
                    {
                        isDead = true;
                    };
                    matrix[targetRow - 1][targetCol] = 'B';
                }
                if (isInside(targetRow + 1, targetCol))
                {
                    if (matrix[targetRow + 1][targetCol] == 'P')
                    {
                        isDead = true;
                    };

                    matrix[targetRow + 1][targetCol] = 'B';
                }
                if (isInside(targetRow, targetCol - 1))
                {
                    if (matrix[targetRow][targetCol - 1] == 'P')
                    {
                        isDead = true;
                    };
                    matrix[targetRow][targetCol - 1] = 'B';
                }
                if (isInside(targetRow, targetCol + 1))
                {
                    if (matrix[targetRow][targetCol + 1] == 'P')
                    {
                        isDead = true;
                    };
                    matrix[targetRow][targetCol + 1] = 'B';
                }
            }
        }
    }
}
