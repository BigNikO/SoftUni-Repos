using System;

namespace Ex4CharacterMultiplier
{
    class CharacterMultiplier
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            string wordOne = input[0];
            string wordTwo = input[1];
            long sum = 0;
            for (int i = 0; i < Math.Min(wordOne.Length, wordTwo.Length); i++)
            {
                sum += wordOne[i] * wordTwo[i];
            }
            for (int i = Math.Min(wordOne.Length, wordTwo.Length);  i < Math.Max(wordOne.Length, wordTwo.Length); i++)
            {
                try
                {
                    sum += wordOne[i];
                }
                catch 
                {

                    sum += wordTwo[i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
