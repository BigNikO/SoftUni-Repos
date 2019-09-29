using System;

namespace Lab2ReverseArrayofIntegers
{
    class ReverseArrayofIntegers
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int[] arr = new int[length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.Write(arr[arr.Length-1]);
            for (int i = arr.Length-2; i >=0 ; i--)
            {
                Console.Write(" "+arr[i]);  
            }
            Console.WriteLine();
        }
    }
}
