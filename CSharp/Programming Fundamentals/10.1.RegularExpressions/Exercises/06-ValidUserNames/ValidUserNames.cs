using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Ex6ValidUserNames
{
    class ValidUserNames
    {
        static void Main(string[] args)
        {
            string[] namesToCheck = Console.ReadLine().Split(new[] { ' ', ',', '(', ')', '\\', '/' }, StringSplitOptions.RemoveEmptyEntries);
            string namePattern = @"\b[A-z]\w{2,25}\b";
            List<string> validNames = new List<string>();
            foreach (var name in namesToCheck)
            {
                Match validName = Regex.Match(name, namePattern);
                if (validName.Success)
                {
                    validNames.Add(Regex.Match(name, namePattern).ToString());
                }
            }
            int maxSum = 0;
            string firstName = "";
            string secondName = "";
            for (int i = 0; i < validNames.Count - 1; i++)
            {
                if (maxSum < validNames[i].Length + validNames[i + 1].Length)
                {
                    maxSum = validNames[i].Length + validNames[i + 1].Length;
                    firstName = validNames[i];
                    secondName = validNames[i + 1];
                }
            }
            Console.WriteLine(firstName);
            Console.WriteLine(secondName);
        }
    }
}
