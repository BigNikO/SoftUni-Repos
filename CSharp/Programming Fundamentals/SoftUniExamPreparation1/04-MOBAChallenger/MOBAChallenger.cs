using System;
using System.Collections.Generic;
using System.Linq;
namespace Ex4MOBAChallenger
{
    class MOBAChallenger
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> playersAndSkills = new Dictionary<string, Dictionary<string, int>>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Season end")
                {
                    break;
                }
                if (input.Split(" ")[1] != "vs")
                {
                    string playerName = input.Split(" -> ")[0];
                    string PlayerSkill = input.Split(" -> ")[1];
                    int skillPoints = int.Parse(input.Split(" -> ")[2]);
                    if (!playersAndSkills.ContainsKey(playerName))
                    {
                        Dictionary<string, int> skills = new Dictionary<string, int>();
                        skills[PlayerSkill] = skillPoints;
                        playersAndSkills[playerName] = skills;
                    }
                    else if (!playersAndSkills[playerName].ContainsKey(PlayerSkill))
                    {
                        playersAndSkills[playerName][PlayerSkill] = skillPoints;
                    }
                    else if (playersAndSkills[playerName][PlayerSkill] < skillPoints)
                    {
                        playersAndSkills[playerName][PlayerSkill] = skillPoints;
                    }
                }
                else
                {
                    string playerOne = input.Split(" vs ")[0];
                    string playerTwo = input.Split(" vs ")[1];
                    if (playersAndSkills.ContainsKey(playerOne) && playersAndSkills.ContainsKey(playerTwo))
                    {
                        foreach (var skill in playersAndSkills[playerOne])
                        {
                            bool demoted = false;
                            foreach (var skill2 in playersAndSkills[playerTwo])
                            {
                                if (skill.Key == skill2.Key)
                                {
                                    if (skill.Value > skill2.Value)
                                    {
                                        playersAndSkills.Remove(playerTwo);
                                        demoted = true;
                                        break;
                                    }
                                    else if (skill.Value == skill2.Value)
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        playersAndSkills.Remove(playerOne);
                                        demoted = true;
                                        break;
                                    }
                                }
                            }
                            if (demoted)
                            {
                                break;
                            }
                        }
                    }
                }
            }
            foreach (var player in playersAndSkills.OrderByDescending(skill => skill.Value.Values.Sum()).ThenBy(playerName => playerName.Key))
            {
                Console.WriteLine($"{player.Key}: {player.Value.Values.Sum()} skill");
                foreach (var skill in player.Value.OrderByDescending(skill => skill.Value))
                {
                    Console.WriteLine($"- {skill.Key} <::> {skill.Value}");
                }
            }
        }
    }
}