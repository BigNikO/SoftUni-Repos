using System;

namespace Exe14IntegerToHexAndBinary
{
    class IntegerToHexAndBinary
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string hexaDecimal = Convert.ToString(number, 16);
            string binary = Convert.ToString(number, 2);
            Console.WriteLine(hexaDecimal.ToUpper());
            Console.WriteLine(binary);

        }
    }
}
