using System;

namespace Lab6ReverseArrayofStrings
{
    class ReverseArrayofStrings
    {

        static void Main(string[] args)
        {
            string[] stringToReverse = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < stringToReverse.Length/2; i++)
            {
                ReverseMethod(stringToReverse, i, stringToReverse.Length-1-i);
            }
            Console.WriteLine(String.Join(" ", stringToReverse));
        }

        static void ReverseMethod(string[] arr, int i, int j)
        {
            string change = arr[i];
            arr[i] = arr[j];
            arr[j] = change;
        }
    }
}
