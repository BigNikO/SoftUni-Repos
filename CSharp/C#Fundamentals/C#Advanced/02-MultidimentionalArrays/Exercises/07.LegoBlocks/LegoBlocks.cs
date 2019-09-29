using System.Text;
using System.Linq;
using System;

namespace Ex7LegoBlocks
{
    class LegoBlocks
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int[][] firstArray = new int[rows][];
            int[][] secondArray = new int[rows][];
            int numberOfCells = 0;
            BuildJaggedArray(firstArray, ref numberOfCells);
            BuildJaggedArray(secondArray, ref numberOfCells);
            PrintArrays(firstArray, secondArray, numberOfCells);
        }
        static void BuildJaggedArray(int[][] jaggedArray, ref int numberOfCells)
        {
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                int[] newRow = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                numberOfCells += newRow.Length;
                jaggedArray[i] = newRow;
            }
        }
        static void PrintArrays(int[][] firstArray, int[][] secondArray, int numberOfCells)
        {
            StringBuilder sb = new StringBuilder();
            int[] firstRow = (firstArray[0].Concat(secondArray[0])).ToArray();
            for (int row = 0; row < firstArray.Length; row++)
            {
                int[] currentRow = firstArray[row].Concat(secondArray[row].Reverse()).ToArray();
                if (firstRow.Length != currentRow.Length)
                {
                    System.Console.WriteLine($"The total number of cells is: {numberOfCells}");
                    return;
                }
                sb.Append($"[{String.Join(", ", currentRow)}]{Environment.NewLine}");
            }
            System.Console.WriteLine(sb.ToString());
        }
    }
}
