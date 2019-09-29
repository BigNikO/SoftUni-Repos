using System;
using System.Collections.Generic;

namespace Ex7PrimesInGivenRange
{
    class PrimesInGivenRange
    {
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());
            List<int> result = FindPrimesInRange(startNum, endNum);
            for (int i = 0; i < result.Count; i++)
            {
                Console.Write($"{result[i]}");
                if (i<result.Count-1)
                {
                    Console.Write(", ");
                }
            }
        }
        static List<int> FindPrimesInRange(int startNum, int endNum)
        {
            bool check;
            List<int> result = new List<int>();
            for (int i = startNum; i <= endNum; i++)
            {
                check = PrimeChecker(i);
                if (check)
                {
                    result.Add(i);
                }       
            }
            return result;
        }
        static bool PrimeChecker(long number)
        {
            bool check = true;
            if (number == 0 || number == 1)
            {
                check = false;
            }
            for (long i = 2; i <= Math.Sqrt(number); i++)
            {
                if ((number % i) == 0)
                {
                    check = false;
                    break;
                }
            }
            return check;
        }
    }
}
