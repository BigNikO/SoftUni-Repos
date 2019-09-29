using System;

namespace Ex9MakeAWord
{
    class MakeAWord
    {
        static void Main(string[] args)
        {
            string result = "The word is: ";
            byte n = byte.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                result += letter;
            }
            Console.WriteLine(result);
        }
    }
}
