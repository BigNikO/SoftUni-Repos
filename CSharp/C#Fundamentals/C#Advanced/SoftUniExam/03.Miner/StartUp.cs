using System;
using System.Linq;

namespace Miner
{
    class StartUp
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            string[] dicrections = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[][] field = new string[n][];
            long col = 0;
            long row = 0;
            long minerCoals = 0;
            long totalCoals = 0;

            for (long i = 0; i < n; i++)
            {
                field[i] = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (field[i].Contains("s"))
                {
                    row = i;
                    col = Array.IndexOf(field[i], "s");
                }
                foreach (var symbol in field[i])
                {
                    if (symbol == "c")
                    {
                        totalCoals++;
                    }
                }
            }
            for (long i = 0; i < dicrections.Length; i++)
            {
                MoveMiner(field, ref row, ref col, dicrections[i]);
                if (Array.IndexOf(field[row], "e") == col)
                {
                    Console.WriteLine($"Game over! ({row}, {col})");
                    return;
                }
                else
                {
                    for (int j = 0; j < field[row].Length; j++)
                    {
                        if (field[row][j] == "c")
                        {
                            if (j == col)
                            {
                                minerCoals++;
                                field[row][col] = "*";
                                if (minerCoals == totalCoals)
                                {
                                    Console.WriteLine($"You collected all coals! ({row}, {col})");
                                    return;
                                }
                            }
                        }
                    }

                }
            }
            Console.WriteLine($"{totalCoals - minerCoals} coals left. ({row}, {col})");
        }
        private static void MoveMiner(string[][] field, ref long row, ref long col, string dicrection)
        {
            long startRow = row;
            long startCol = col;
            switch (dicrection)
            {
                case "up": row--; break;
                case "down": row++; break;
                case "left": col--; break;
                case "right": col++; break;
                default:
                    break;
            }
            if (row >= field.Length || row < 0 || col >= field.Length || col < 0)
            {
                row = startRow;
                col = startCol;
                field[row][col] = "s";
            }
            else if (field[row][col] != "e" && field[row][col] != "c")
            {
                field[row][col] = "s";
            }
        }
    }
}
