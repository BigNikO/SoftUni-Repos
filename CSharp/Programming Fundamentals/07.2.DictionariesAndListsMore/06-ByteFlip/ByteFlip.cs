using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex6ByteFlip
{
    class ByteFlip
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine().Split().ToList();
            List<char> result = new List<char>();
            numbers.Reverse();
            List<char[]> reversed = new List<char[]>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i].Length!=2)
                {
                    numbers.Remove(numbers[i]);
                    i--;
                }
            }
            for (int i = 0; i < numbers.Count; i++)
            {                
                numbers[i] = new string(numbers[i].Reverse().ToArray());
                result.Add((char)(ParseHexString(numbers[i])));
            }
            Console.WriteLine(string.Join("",result));
        }
        private static int ParseHexString(string hexNumber)
        {
            int result = 0;
            int.TryParse(hexNumber, System.Globalization.NumberStyles.HexNumber, null, out result);
            return result;
        }
    }
}
