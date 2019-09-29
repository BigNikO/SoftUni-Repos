using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex9TeamWorkProject
{
    class TeamWorkProject
    {
        static void Main(string[] args)
        {
            int numberOfTeams = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();
            for (int i = 0; i < numberOfTeams; i++)
            {
                string input = Console.ReadLine();
                string name = input.Split("-")[1];
                string user = input.Split("-")[0];
                Team team = ReadTeam(name, user);
                if (i > 0 && AlreadyCreated(teams, name))
                {
                    Console.WriteLine($"Team {name} was already created!");
                }
                else if (i > 0 && SameCreator(teams, user))
                {
                    Console.WriteLine($"{user} cannot create another team!");
                }
                else
                {
                    Console.WriteLine($"Team {team.Name} has been created by {team.User[0]}!");
                    teams.Add(team);
                }
            }
            string newUsers;
            while ((newUsers = Console.ReadLine()) != "end of assignment")
            {
                string teamName = newUsers.Split("->")[1];
                string newUser = newUsers.Split("->")[0];
                if (!TeamExist(teams, teamName))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
                else if (AlreadyInATeam(teams, newUser))
                {
                    Console.WriteLine($"Member {newUser} cannot join team {teamName}!");
                }
                else
                {
                    foreach (var item in teams)
                    {
                        if (item.Name == teamName)
                        {
                            item.User.Add(newUser);
                            break;
                        }
                    }
                }
            }
            foreach (var item in teams.OrderByDescending(x => x.User.Count).ThenBy(x => x.Name))
            {
                if (item.User.Count > 1)
                {
                    Console.WriteLine(item.Name);
                    Console.WriteLine("- " + item.User[0]);
                    foreach (var user in item.User.Skip(1).OrderBy(x => x))
                    {
                        Console.WriteLine("-- " + user);
                    }
                }
            }
            Console.WriteLine("Teams to disband:");
            foreach (var item in teams.OrderBy(x => x.Name))
            {
                if (item.User.Count == 1)
                {
                    Console.WriteLine(item.Name);
                }
            }
        }
        private static bool TeamExist(List<Team> teams, string name)
        {
            return teams.Any(x => x.Name == name);
        }
        private static bool AlreadyInATeam(List<Team> teams, string user)
        {
            return teams.Any(x => x.User.Any(y => y == user));
        }
        private static bool SameCreator(List<Team> teams, string user)
        {
            return teams.Any(x => x.User.Any(y => y == user));
        }
        public static bool AlreadyCreated(List<Team> teams, string name)
        {
            return teams.Any(x => x.Name == name);
        }
        public static Team ReadTeam(string teamName, string creator)
        {
            Team team = new Team();
            team.Name = teamName;
            team.User = new List<string>();
            team.User.Add(creator);
            return team;
        }
    }
    public class Team
    {
        public string Name { get; set; }
        public List<String> User { get; set; }
    }
}
