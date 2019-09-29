using System;
using System.Linq;

namespace Ex9JumpAround
{
    class JumpAround
    {
        static void Main(string[] args)
        {
            long[] theArray = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            long i = 0;
            long jumpSum = 0;
            long length = theArray.Length;
            while (i>=0)
            {
                if (theArray[i]+i < length)
                {
                    jumpSum += theArray[i];
                    i = theArray[i] + i;
                }
                else if (i-theArray[i] >= 0)
                {
                    jumpSum += theArray[i];
                    i = Math.Abs(theArray[i] - i);
                }
                else
                {
                    jumpSum += theArray[i];
                    break;
                }
            }
            Console.WriteLine(jumpSum);
        }
    }
}
