using System;

namespace Ex4VariableInHexFormat
{
    class VariableInHexFormat
    {
        static void Main(string[] args)
        {
            string hexaDecimal = (Console.ReadLine());
            int decimalFormat = Convert.ToInt32(hexaDecimal, 16);
            Console.WriteLine(decimalFormat);
        }
    }
}