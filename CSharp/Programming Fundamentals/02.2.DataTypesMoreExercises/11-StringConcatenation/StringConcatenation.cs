using System;

namespace Exe11StringConcatenation
{
    class StringConcatenation
    {
        static void Main(string[] args)
        {
            string separator = Console.ReadLine();
            string evenOdd = Console.ReadLine();
            string result = "";
            int n = int.Parse(Console.ReadLine());
            if (evenOdd=="even")
            {                  
                for (int i = 1; i <= n; i++)
                {
                    string word = Console.ReadLine();
                    if (i%2==0)
                    {
                        result += word+separator;
                    }                   
                }
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    string word = Console.ReadLine();
                    if (i % 2 != 0)
                    {
                        result += word+separator;
                    }
                }
            }
            Console.WriteLine(result.Trim(char.Parse(separator)));
        }
    }
}
