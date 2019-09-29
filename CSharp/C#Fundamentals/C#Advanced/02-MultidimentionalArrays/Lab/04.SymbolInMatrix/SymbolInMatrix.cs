using System;

namespace Lab4SymbolInMatrix
{
    class SymbolInMatrix
    {
        public static void Main (string[] args)
        {
            var n = int.Parse (Console.ReadLine ());

            var matrix = new char[n, n];

            for (var row = 0; row < n; row++)
            {
                var colValues = Console.ReadLine ()?.ToCharArray ();

                for (var col = 0; col < n; col++)
                {
                    if (colValues != null) matrix[row, col] = colValues[col];
                }
            }

            var searchedSymbol = char.Parse (Console.ReadLine ());

            for (var row = 0; row < n; row++)
            {
                for (var col = 0; col < n; col++)
                {
                    if (searchedSymbol != matrix[row, col]) continue;
                    Console.WriteLine ($"({row}, {col})");
                    return;
                }
            }

            Console.WriteLine ($"{searchedSymbol} does not occur in the matrix");
        }
    }
}