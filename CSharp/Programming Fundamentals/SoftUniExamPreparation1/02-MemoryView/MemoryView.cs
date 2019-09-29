using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
namespace Ex2MemoryView
{
    class MemoryView
    {
        static void Main(string[] args)
        {          
            string matchPattern = @"32656 19759 32763 0 (\d{1,2}) 0 ((\d{2,3}\s)+)";
            string input = null;
            while (true)
            {
                string readLine = Console.ReadLine();
                
                if (readLine == "Visual Studio crash")
                {
                    break;
                }
                input += readLine+" ";
            }
            foreach (Match pattern in Regex.Matches(input,matchPattern))
            {      
                List<int> numbers = pattern.Groups[2].Value.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
                int count = int.Parse(pattern.Groups[1].Value);
                string result = null;
                for (int number = 0; number < count; number++)
                {
                    result += (char)numbers[number];
                }
                Console.WriteLine(result);
            }          
        }
    }
}
