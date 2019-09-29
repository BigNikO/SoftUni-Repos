using System;

namespace Exe10SumOfChars
{
    class SumOfChars
    {
        static void Main(string[] args)
        {
            int totalSum = 0;          
            int numberofLines = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberofLines; i++)
            {
                totalSum += char.Parse(Console.ReadLine());
            }
            string result = $"The sum equals: {totalSum}";
            Console.WriteLine(result);
        }
    }
}
