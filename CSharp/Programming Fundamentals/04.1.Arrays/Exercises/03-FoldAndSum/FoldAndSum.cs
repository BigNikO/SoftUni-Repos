using System;
using System.Linq;

namespace Exe3FoldAndSum
{
    class FoldAndSum
    {
        static void Main(string[] args)
        {
            int[] theArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int lengthSide = (theArray.Length)/4;
            int[] sumArray = new int[2 * lengthSide];
            
            for (int i = 0; i < 2*lengthSide; i++)
            {
                sumArray[i] += theArray[i+lengthSide];
            }
            theArray = connectSides(theArray, lengthSide);
            for (int i = 0; i < 2 * lengthSide; i++)
            {
                sumArray[i] += theArray[i];
            }
            Console.WriteLine(String.Join(' ', sumArray));
        }
        static int[] connectSides(int[] array, int length)
        {
            int[] sidesArray = new int[2*length];
            for (int i = 0; i < length; i++)
            {
                sidesArray[i] = array[length-i-1];
            }
            for (int i = 2*length-1; i >= length; i--)
            {
                sidesArray[i] = array[5*length-1-i];
            }
            return sidesArray;
        }
    }
}
