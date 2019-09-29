using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Pb3StarEnigma
{
    class StarEnigma
    {
        static void Main(string[] args)
        {
            string decryptPattern = @"[starSTAR]";
            int numberOfMessages = int.Parse(Console.ReadLine());
            List<string> attackedPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();
            for (int i = 0; i < numberOfMessages; i++)
            {
                string message = Console.ReadLine();
                int cipher = Regex.Matches(message, decryptPattern).Count;
                string decryptedMessage = null;
                foreach (var character in message)
                {
                    decryptedMessage += (char)(character - cipher);
                }
                string finalPatter = @"@([A-Za-z]+)[^@:!\->]*:([\d]+)[^@:!\->]*!([A|D])![^@:!\->]*->([\d]+)";
                string check = Regex.Match(decryptedMessage, finalPatter).ToString();
                    if (Regex.Match(decryptedMessage, finalPatter).Groups[3].Value == "A")
                    {
                        attackedPlanets.Add(Regex.Match(decryptedMessage, finalPatter).Groups[1].Value);
                    }
                    else if ((Regex.Match(decryptedMessage, finalPatter).Groups[3].Value == "D"))
                    {
                        destroyedPlanets.Add(Regex.Match(decryptedMessage, finalPatter).Groups[1].Value);
                    }           
            }
            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");
            foreach (var planet in attackedPlanets.OrderBy(name=>name))
            {
                Console.WriteLine($"-> {planet}");
            }
            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");
            foreach (var planet in destroyedPlanets.OrderBy(name => name))
            {
                Console.WriteLine($"-> {planet}");
            }
        }
    }
}
