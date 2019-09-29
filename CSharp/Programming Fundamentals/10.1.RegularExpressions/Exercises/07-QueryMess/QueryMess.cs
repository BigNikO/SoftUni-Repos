using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Ex7QueryMess
{
    class QueryMess
    {
        static void Main(string[] args)
        {
            string replacePattern = @"\+|\%20";
            string pattern = @"(^|&|\?)([^?=]+)=([^&]+)";
            
            while (true)
            {
                Dictionary<string, List<string>> fieldValue = new Dictionary<string, List<string>>();
                string input = Console.ReadLine();
                if (input == "END") { break; }
                input = Regex.Replace(input, replacePattern, " ");
                input = Regex.Replace(input, @"\s+", " ");
                MatchCollection matchResults = Regex.Matches(input, pattern);
                foreach (Match result in matchResults)
                {
                    for (int i = 2; i <= result.Groups.Count - 1; i += 2)
                    {
                        if (fieldValue.ContainsKey(result.Groups[i].Value.Trim()))
                        {
                            fieldValue[result.Groups[i].Value.Trim()].Add(result.Groups[i + 1].Value.Trim());
                        }
                        else
                        {
                            fieldValue[result.Groups[i].Value.Trim()] = new List<string>();
                            fieldValue[result.Groups[i].Value.Trim()].Add(result.Groups[i + 1].Value.Trim());
                        }                      
                    }
                }
                foreach (var field in fieldValue)
                {
                    Console.Write(field.Key + "=[");
                    Console.Write(string.Join(", ", field.Value));
                    Console.Write("]");
                }
                Console.WriteLine();
            }
        }
    }
}
