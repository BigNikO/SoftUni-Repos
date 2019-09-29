using System;
using System.Linq;
using System.Numerics;

namespace lab3PrimaryDiagonal
{
    class PrimaryDiagonal
    {
        static void Main ()
        {
            var n = int.Parse (Console.ReadLine ());

            var matrix = new int[n, n];

            for (var row = 0; row < matrix.GetLength (0); row++)
            {
                var colValues = Console.ReadLine ()?.Split ().Select (int.Parse).ToArray ();

                for (var col = 0; col < matrix.GetLength (1); col++)
                {
                    matrix[row, col] = colValues[col];
                }
            }

            var sum = 0;
            for (var row = 0; row < matrix.GetLength (0); row++)
            {
                sum += matrix[row, row];
            }

            Console.WriteLine (sum);
        }
    }
}