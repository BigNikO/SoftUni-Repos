using System;
using System.Text.RegularExpressions;

namespace Ex5OnlyLetters
{
    class OnlyLetters
    {
        static void Main(string[] args)
        {
            string pattern = @"(\d+)([A-z])";
            string textInput = Console.ReadLine();
            foreach (Match number in Regex.Matches(textInput,pattern))
            {
                textInput = Regex.Replace(textInput, number.ToString(), number.Groups[2].Value+number.Groups[2].Value);
            }
            Console.WriteLine(textInput);
        }
    }
}
