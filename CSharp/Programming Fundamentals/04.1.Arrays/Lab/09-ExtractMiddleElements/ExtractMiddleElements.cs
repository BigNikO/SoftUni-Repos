using System;
using System.Linq;

namespace Lab9ExtractMiddleElements
{
    class ExtractMiddleElements
    {
        static void Main(string[] args)
        {
            int[] theArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            ExtractMiddle(theArray);

        }
        static void ExtractMiddle(int[] array)
        {
            if (array.Length==1)
            {
                Console.WriteLine(array[0]);
            }
            else if (array.Length % 2!=0)
            {
                Console.WriteLine($"{array[array.Length / 2 - 1]} {array[array.Length / 2]} {array[array.Length / 2 + 1]}");
            }
            else
            {
                Console.WriteLine(($"{array[array.Length / 2 - 1]} {array[array.Length / 2]}"));
            }
        }
    }
}
