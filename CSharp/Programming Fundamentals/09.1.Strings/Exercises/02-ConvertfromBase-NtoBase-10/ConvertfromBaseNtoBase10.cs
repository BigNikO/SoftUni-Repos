using System;
using System.Linq;
using System.Numerics;

namespace Ex2ConvertfromBase_NtoBase_10
{
    class ConvertfromBaseNtoBase10
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int theBase = int.Parse(input[0]);
            BigInteger number = 0;
            char[] stringNumber = input[1].Reverse().ToArray();
            for (int i = 0; i < stringNumber.Length; i++)
            {
                number += (BigInteger)((int)(char.GetNumericValue(stringNumber[i])*(Math.Pow(theBase,i))));
            }
            Console.WriteLine(number);
        }
    }
}
