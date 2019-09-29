using System;

namespace Exe13VowelOrDigit
{
    class VowelOrDigit
    {
        static void Main(string[] args)
        {
            string symbol = (Console.ReadLine());
            int num;
            string check = "other";
            bool checkSymbol = int.TryParse(symbol, out num);
            if (checkSymbol)
            {
                check = "digit";
            }
            if (symbol == "a" || symbol == "e" || symbol == "i" 
            || symbol == "o" ||symbol == "u" || symbol == "y")
            {
                check = "vowel";
            }
            Console.WriteLine(check);           
        }
    }
}
