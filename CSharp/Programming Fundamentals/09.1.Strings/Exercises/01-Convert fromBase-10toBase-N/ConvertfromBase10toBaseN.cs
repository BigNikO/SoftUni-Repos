using System;
using System.Linq;
using System.Numerics;

namespace Ex1Convert_fromBase_10toBase_N
{
    class ConvertfromBase10toBaseN
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int theBase = int.Parse(input[0]);
            BigInteger number = BigInteger.Parse(input[1]);
            string result = null;
            while (number>0)
            {
                result = (number % theBase).ToString()+result;
                number = number / theBase;
            }
            Console.WriteLine(result);
        }
    }
}
