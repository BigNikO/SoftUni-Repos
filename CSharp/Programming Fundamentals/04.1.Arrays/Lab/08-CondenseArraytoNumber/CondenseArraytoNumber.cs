using System;
using System.Linq;

namespace Lab8CondenseArraytoNumber
{
    class CondenseArraytoNumber
    {
        static void Main(string[] args)
        {
            int[] theArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            while (theArray.Length>=2)
            {
                int[] newArray = new int[theArray.Length - 1];
                for (int i = 0; i < newArray.Length; i++)
                {
                    newArray[i] = theArray[i] + theArray[i + 1];
                }
                theArray = newArray;
            }
            Console.WriteLine(theArray[0]);

        }
    }
}
