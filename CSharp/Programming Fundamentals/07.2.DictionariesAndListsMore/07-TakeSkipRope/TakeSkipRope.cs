using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Ex7.TakeSkipRope
{
    class TakeSkipRope
    {
        static void Main(string[] args)
        {
            string patternDigits = @"[0-9]";
            string encryptedtext = Console.ReadLine();
            List<int> digits = new List<int>();
            foreach (Match digit in Regex.Matches(encryptedtext, patternDigits))
            {
                digits.Add(int.Parse(digit.ToString()));
            }
            string textToDecrypt = Regex.Replace(encryptedtext, patternDigits, "");
            string decriptedText = "";
            string restText = textToDecrypt;
            for (int i = 1; i <= digits.Count; i++)
            {
                if (i % 2 != 0)
                {
                    try
                    {
                        decriptedText += restText.Substring(0, digits[i - 1]);
                    }
                    catch (Exception)
                    {
                        decriptedText += restText.Substring(0, restText.Length);
                    }
                }
                try
                {
                    restText = restText.Substring(digits[i - 1]);
                }
                catch (Exception)
                {
                    restText = restText.Substring(restText.Length);
                }
            }
            Console.WriteLine(decriptedText);
        }
    }
}
