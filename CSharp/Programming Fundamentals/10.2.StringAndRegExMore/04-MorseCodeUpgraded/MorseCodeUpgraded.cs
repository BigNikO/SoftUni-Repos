using System;
using System.Text.RegularExpressions;

namespace Ex4MorseCodeUpgraded
{
    class MorseCodeUpgraded
    {
        static void Main(string[] args)
        {
            string patternZeros = "0{2,}";
            string patternUnits = "1{2,}";
            string[] inputs = Console.ReadLine().Split('|');
            foreach (var input in inputs)
            {
            int sum = 0;
            int zeroSequence = 0;
            foreach (Match zeros in Regex.Matches(input,patternZeros))
            {
                zeroSequence += zeros.Length;
            }
            int oneSequence = 0;
            foreach (Match ones in Regex.Matches(input, patternUnits))
            {
                oneSequence += ones.Length;
            }
            foreach (var digit in input)
            {
                if (digit=='1')
                {
                    sum += 5;
                }
                else
                {
                    sum += 3;
                }
            }
            sum += zeroSequence+oneSequence;      
            Console.Write((char)sum);
            }
            Console.WriteLine();
        }
    }
}
