using System;
using System.Linq;

namespace Exe2RotateAndSum
{
    class RotateAndSum
    {
        static void Main(string[] args)
        {
            int[] theArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rotationNumber = int.Parse(Console.ReadLine());
            int[] sumArray = new int[theArray.Length];

            // Sum the rotations
            for (int i = 1; i <= rotationNumber; i++)
            {
                RotateMethod(theArray);
                for (int j = 0; j < theArray.Length; j++)
                {
                    sumArray[j] += theArray[j];
                }
            }
            Console.WriteLine(string.Join(" ", sumArray));
        }
        // RotateMethod
        private static void RotateMethod(int[] array)
        {
            int lastNumber = array[array.Length-1];
            for (int i = array.Length - 1; i >0; i--)
            {
                array[i] = array[i-1];
            }
            array[0] = lastNumber;
        }
    }
}
