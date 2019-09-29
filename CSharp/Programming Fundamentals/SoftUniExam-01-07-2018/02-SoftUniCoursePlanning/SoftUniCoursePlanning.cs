using System;
using System.Collections.Generic;
using System.Linq;
namespace Ex2SoftUniCoursePlanning
{
    class SoftUniCoursePlanning
    {
        static void Main(string[] args)
        {
            List<string> lessons = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
            while (true)
            {
                string[] command = Console.ReadLine().Split(":");
                if (command[0] == "course start")
                {
                    break;
                }
                if (command[0] == "Add"&&!lessons.Contains(command[1]))
                {
                    lessons.Add(command[1]);
                }
                else if (command[0] == "Insert" && lessons.Count >= int.Parse(command[2]))
                {
                    if (!lessons.Contains(command[1])&&int.Parse(command[2])>=0)
                    {
                        lessons.Insert(int.Parse(command[2]), command[1]);
                    }
                }
                else if (command[0] == "Remove" && lessons.Contains(command[1]))
                {
                    if (lessons.IndexOf(command[1]) + 1 < lessons.Count && lessons[lessons.IndexOf(command[1]) + 1].Contains(command[1]))
                    {
                        lessons.Remove(lessons[lessons.IndexOf(command[1]) + 1]);
                    }
                    lessons.Remove(command[1]);
                }
                else if (command[0] == "Swap" && lessons.Contains(command[1]) && lessons.Contains(command[2]))
                {
                    int indexOne = lessons.IndexOf(command[1]);
                    int indexTwo = lessons.IndexOf(command[2]);
                    lessons[indexOne] = command[2];
                    lessons[indexTwo] = command[1];
                    if (indexOne + 1 < lessons.Count && indexTwo + 1 < lessons.Count && lessons[indexOne + 1].Contains(command[1]) && lessons[indexTwo + 1].Contains(command[2]))
                    {
                        string temporary = lessons[indexTwo + 1];
                        lessons[indexTwo + 1] = lessons[indexOne + 1];
                        lessons[indexOne + 1] = temporary;
                    }
                    else if (indexOne + 1 < lessons.Count && lessons[indexOne + 1].Contains(command[1]+"-"))
                    {
                        string temporary = (lessons[indexOne + 1]);
                        lessons.Remove(lessons[indexOne + 1]);
                        indexTwo = lessons.IndexOf(command[1]);
                        if (indexTwo + 1 <= lessons.Count)
                        {
                            lessons.Insert(indexTwo + 1, temporary);
                        }
                        else
                        {
                            lessons.Add(temporary);
                        }
                    }
                    else if (indexTwo + 1 < lessons.Count && lessons[indexTwo + 1].Contains(command[2]+"-"))
                    {
                        string temporary = (lessons[indexTwo + 1]);
                        lessons.Remove(lessons[indexTwo + 1]);
                        indexOne = lessons.IndexOf(command[2]);
                        if (indexOne + 1 <= lessons.Count)
                        {
                            lessons.Insert(indexOne + 1, temporary);
                        }
                        else
                        {
                            lessons.Add(temporary);
                        }

                    }
                }
                else if (command[0] == "Exercise")
                {
                    if (lessons.Contains(command[1]))
                    {
                        if (!lessons.Contains(command[1]+"-"+command[0]))
                        {
                            lessons.Insert(lessons.IndexOf(command[1]) + 1, command[1]+"-"+command[0]);
                        }
                    }
                    else
                    {
                       lessons.Add(command[1]);                    
                       lessons.Add(command[1] + "-" + command[0]);
                    }
                }
            }
            int i = 1;
            foreach (var item in lessons)
            {
                Console.WriteLine(i + "." + item);
                i++;
            }
        }
    }
}
