using System;
using System.Collections.Generic;
using System.Linq;

namespace Tagram
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var users = new Dictionary<string, Dictionary<string, int>>();
            string input = "";
            while ((input = Console.ReadLine()) != "end")
            {
                if (!input.Contains("ban"))
                {
                    string username = input.Split(" -> ")[0];
                    string tag = input.Split(" -> ")[1];
                    int likes = int.Parse(input.Split(" -> ")[2]);
                    if (!users.ContainsKey(username))
                    {
                        Dictionary<String, int> tagLikes = new Dictionary<string, int>();
                        tagLikes.Add(tag, likes);
                        users[username] = tagLikes;
                    }
                    else
                    {
                        if (!users[username].ContainsKey(tag))
                        {
                            users[username][tag] = likes;
                        }
                        else
                        {
                            users[username][tag]++;

                        }
                    }
                }
                else
                {
                    string username = input.Split(" ")[1];
                    if (users.ContainsKey(username))
                    {
                        users.Remove(username);
                    }
                }
            }
            foreach (var username in users.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(x => x.Value.Count))
            {
                Console.WriteLine(username.Key);
                foreach (var tag in username.Value)
                {
                    Console.WriteLine($"- {tag.Key}: {tag.Value}");
                }
            }
        }
    }
}
