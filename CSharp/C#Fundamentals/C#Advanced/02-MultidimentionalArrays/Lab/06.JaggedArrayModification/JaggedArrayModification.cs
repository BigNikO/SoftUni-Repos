using System;
using System.Linq;

namespace Lab6JaggedArrayModification
{
    class JaggedArrayModification
    {
        static void Main (string[] args)
        {
            int n = int.Parse (Console.ReadLine ());
            int[][] juggedArray = new int[n][];

            for (int i = 0; i < n; i++)
            {
                int[] inputArray = Console.ReadLine ().Split ().Select (int.Parse).ToArray ();

                juggedArray[i] = inputArray;
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
                        juggedArray[row][col] += value;
                    }
                    else
                    {
                        juggedArray[row][col] -= value;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine ("Invalid coordinates");
                }
            }

            foreach (int[] row in juggedArray)
            {
                Console.WriteLine (String.Join (" ", row));
            }
        }
    }
}