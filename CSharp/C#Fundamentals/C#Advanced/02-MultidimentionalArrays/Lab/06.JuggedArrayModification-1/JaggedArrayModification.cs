using System;
using System.Linq;

namespace Lab6JaggedArrayModification_1
{
    class JaggedArrayModification
    {
        static void Main (string[] args)
        {
            int n = int.Parse (Console.ReadLine ());
            int[, ] matrix = new int[n, n];

            for (int row = 0; row < n; row++)
            {
                int[] colElements = Console.ReadLine ().Split ().Select (int.Parse).ToArray ();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }
            while (true)
            {
                string command = Console.ReadLine ();
                if (command == "END")
                {
                    break;
                }
                int row = int.Parse (command.Split () [1]);
                int col = int.Parse (command.Split () [2]);
                int value = int.Parse (command.Split () [3]);
                try
                {
                    if (command.Split () [0] == "Add")
                    {
                        matrix[row, col] += value;
                    }
                    else
                    {
                        matrix[row, col] -= value;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine ("Invalid coordinates");
                }
            }
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write (matrix[row, col] + " ");
                }
                Console.WriteLine ();
            }
        }
    }
}