using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Ex6EmailStatistics
{
    class EmailStatistics
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> userMail = new Dictionary<string, List<string>>();
            string pattern = @"^([a-zA-Z]{5,})@([a-z]{3,}.)(bg|com|org)$";
            int emailsCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < emailsCount; i++)
            {
                Match mail = Regex.Match(Console.ReadLine(), pattern);
                if (mail.Groups[3].Value == "com" || mail.Groups[3].Value == "org" || mail.Groups[3].Value == "bg")
                {
                    if (!userMail.ContainsKey(mail.Groups[2].Value + mail.Groups[3].Value))
                    {
                        userMail[mail.Groups[2].Value + mail.Groups[3].Value] = new List<string>();
                        userMail[mail.Groups[2].Value + mail.Groups[3].Value].Add(mail.Groups[1].Value);
                    }
                    else if(!userMail[mail.Groups[2].Value + mail.Groups[3].Value].Contains(mail.Groups[1].Value))
                    {
                        userMail[mail.Groups[2].Value + mail.Groups[3].Value].Add(mail.Groups[1].Value);
                    }
                }
            }
            foreach (var domain in userMail.OrderByDescending(x=>x.Value.Count))
            {
                Console.WriteLine(domain.Key+":");
                foreach (var user in domain.Value)
                {
                    Console.WriteLine($"### {user}");
                }
            }
        }
    }
}
