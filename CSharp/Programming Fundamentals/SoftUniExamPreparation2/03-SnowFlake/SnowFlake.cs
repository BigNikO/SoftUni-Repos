using System;
using System.Text.RegularExpressions;

namespace Ex3SnowFlake
{
    class SnowFlake
    {
        static void Main(string[] args)
        {
            string surfacepattern = @"^[^0-9a-zA-Z]+$";
            string mantlePattern = @"^[0-9_]+$";
            string pattern = @"^([^0-9a-zA-Z]+)([0-9_]+)([a-zA-Z]+)([0-9_]+)([^0-9a-zA-Z]+)$";
            string input = null;
            string core = null;
            bool isValid = true;
            for (int i = 0; i < 5; i++)
            {
                input = Console.ReadLine();
                if (i==0||i==4)
                {
                    Match validation = Regex.Match(input, surfacepattern);
                    if (!validation.Success)
                    {
                        isValid = false;
                        break;
                    }
                }
                else if (i==1||i==3)
                {
                    Match validation = Regex.Match(input, mantlePattern);
                    if (!validation.Success)
                    {
                        isValid = false;
                        break;
                    }
                }
                else
                {
                    Match validation = Regex.Match(input, pattern);
                    if (!validation.Success)
                    {
                        isValid = false;
                        break;
                    }
                    else
                    {
                        core = validation.Groups[3].Value;
                    }
                }

            }
            if (isValid)
            {
                Console.WriteLine("Valid");
                Console.WriteLine(core.Length);
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
