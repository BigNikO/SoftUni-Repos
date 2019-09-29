using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex8Ranking
{
    class Ranking
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contests = new Dictionary<string, string>();
            Dictionary<string, Dictionary<string, int>> studentResults = new Dictionary<string, Dictionary<string, int>>();

            string inputContest;
            while ((inputContest = Console.ReadLine()) != "end of contests")
            {
                string contest = inputContest.Split(":")[0];
                string password = inputContest.Split(":")[1];
                contests[contest] = password;
            }
            while ((inputContest = Console.ReadLine()) != "end of submissions")
            {
                string contest = inputContest.Split("=>")[0];
                string password = inputContest.Split("=>")[1];
                string student = inputContest.Split("=>")[2];
                int points = int.Parse(inputContest.Split("=>")[3]);
                if (!studentResults.ContainsKey(student))
                {
                    var results = new Dictionary<string, int>();
                    if (contests.ContainsKey(contest))
                    {
                        if (contests[contest] == password)
                        {
                            results[contest] = points;
                            studentResults[student] = results;
                        }
                    }
                }
                else if (contests.ContainsKey(contest) && (contests[contest] == password))
                {
                    if (!studentResults[student].ContainsKey(contest))
                    {
                        studentResults[student][contest] = points;
                    }
                    else
                    {
                        if (studentResults[student][contest] < points)
                        {
                            studentResults[student][contest] = points;
                        }
                    }
                }
            }
            var firstStudent = studentResults.OrderByDescending(x => x.Value.Values.Sum()).First();
            Console.WriteLine($"Best candidate is {firstStudent.Key} with total {firstStudent.Value.Values.Sum()} points.");
            // Console.WriteLine($"Best candidate is {firstStudent.Key} with total {firstStudent.Value.Values.Aggregate((a,b)=>a+b)} points.");
            Console.WriteLine("Ranking: ");
            foreach (var studentResult in studentResults.OrderBy(x => x.Key))
            {
                Console.WriteLine(studentResult.Key);
                foreach (var result in studentResult.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {result.Key} -> {result.Value}");
                }
            }
        }
    }
}

