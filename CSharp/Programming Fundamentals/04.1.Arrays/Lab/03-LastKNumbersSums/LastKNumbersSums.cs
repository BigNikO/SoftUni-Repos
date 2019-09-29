using System;
using System.Linq;

namespace Lab3LastKNumbersSums
{
    class LastKNumbersSums
    {
        // Main Method
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            long[] array = new long [n];
            ReadArr(array, k, n);
            PrintArr(array);
        }

        // Method - Read Array

        static void ReadArr(long[] array, int k, int n)
        {
            array[0] = 1;
            for (int i = 1; i < array.Length; i++)
            {
                long sum = 0;
                for (int j = i - k; j < i ;j++)
                {
                    if (j >= 0)
                    {
                        sum += array[j];
                    }
                }
                array[i] = sum;
            }
        }

        // Method Print Array
        static void PrintArr(long[] array)
        {
            Console.WriteLine(string.Join(" ", array));
        }
    }
}
