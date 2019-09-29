using System;

namespace Exe9IndexofLetters
{
    class IndexofLetters
    {
        static void Main(string[] args)
        {
            string letters = "abcdefghijklmnopqrstuvwxyz";
            byte[] indexArray = new byte[letters.Length];
            byte index = 0;
            for (int i = 0; i < letters.Length; i++)
            {
                indexArray[i] = index;
                index++;
            }
            letters = Console.ReadLine();
            for (int i = 0; i < letters.Length; i++)
            {
                Console.WriteLine($"{letters[i]} -> {indexArray[letters[i]-(byte)'a']}");
            }
        }
    }
}
