using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Exe10StudentGroups
{
    class Student
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime RegisterDate { get; set; }
    }
    class Town
    {
        public string Name { get; set; }
        public int LabCapacity { get; set; }
        public List<List<Student>> Groups { get; set; }
    }
    class StudentGroups
    {
        static void Main(string[] args)
        {
            List<Town> towns = new List<Town>();
            List<List<Student>> currentGroups = new List<List<Student>>();
            List<Student> currentStudents = new List<Student>();
            List<int> townGroups = new List<int>();
            string inputLine = Console.ReadLine();
            Town currentTown = new Town();
            while (inputLine != "End")
            {
                if (inputLine.Contains("=>"))
                {
                    currentTown = new Town();
                    string townName = inputLine.Split("=>")[0].Trim();
                    string labCapacity = inputLine.Split(' ')[inputLine.Split(' ').Length - 2].Trim();
                    currentTown.Name = townName;
                    currentTown.LabCapacity = int.Parse(labCapacity);
                    towns.Add(currentTown);
                    currentStudents = new List<Student>();
                    currentGroups = new List<List<Student>>();
                    inputLine = Console.ReadLine();
                }
                int currentTownGroups = 1;
                while (!(inputLine.Contains("=>")) && !(inputLine == "End"))
                {
                    Student currentStudent = new Student();
                    string studentName = inputLine.Split('|')[0].Trim();
                    string email = inputLine.Split('|')[1].Trim();
                    DateTime regDate = DateTime.ParseExact(inputLine.Split('|')[2].Trim(), "d-MMM-yyyy", CultureInfo.InvariantCulture);
                    currentStudent.Name = studentName;
                    currentStudent.Email = email;
                    currentStudent.RegisterDate = regDate;
                    currentStudents.Add(currentStudent);
                    currentStudents = currentStudents.OrderBy(x => x.RegisterDate).ThenBy(x=>x.Name).ThenBy(x=>x.Email).ToList();
                    if (currentTown.LabCapacity * currentTownGroups == currentStudents.Count - 1)
                    {
                        currentTownGroups++;
                    }
                    inputLine = Console.ReadLine();
                }
                townGroups.Add(currentTownGroups);
                currentGroups.Add(currentStudents);
                currentTown.Groups = currentGroups;
            }
            for (int i = 0; i < towns.Count; i++)
            {
                for (int j = 0; j < townGroups[i]; j++)
                {
                    towns[i].Groups.Add(new List<Student>());
                    for (int k = 0; k < towns[i].LabCapacity&&k<towns[i].Groups[0].Count; k++)
                    {
                        if (j>0)
                        {
                            k += towns[i].LabCapacity*j;
                            if (k < towns[i].Groups[0].Count)
                            {
                                towns[i].Groups[j+1].Add(towns[i].Groups[0][k]);                               
                            }
                            k -= towns[i].LabCapacity * j;
                        }
                        else
                        {
                            towns[i].Groups[j+1].Add(towns[i].Groups[0][k]);
                        }                      
                    }
                }
                towns[i].Groups.Remove(towns[i].Groups[0]);
            }
            Console.WriteLine($"Created {townGroups.Sum()} groups in {towns.Count} towns:");
            foreach (var town in towns.OrderBy(x => x.Name))
            {
                foreach (var group in town.Groups)
                {                   
                    string emails = string.Join(", ", group.Select(x => x.Email));
                    Console.WriteLine($"{town.Name} => {emails}");
                }
            }
        }
    }
}
