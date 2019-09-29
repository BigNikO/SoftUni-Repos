using System;
using System.Collections.Generic;
using System.Linq;

namespace FamilyTree
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string personInfo = Console.ReadLine();
            string personToFindInfo = personInfo;
            List<Person> people = new List<Person>();
            List<String> peopleInfo = new List<String>();
            while ((personInfo = Console.ReadLine()) != "End")
            {

                if (personInfo.Contains("-"))
                {
                    peopleInfo.Add(personInfo);
                }
                else
                {
                    string[] currentPerson = personInfo.Split();
                    string name = currentPerson[0] + " " + currentPerson[1];
                    string birthDate = currentPerson[2];
                    Person person = new Person() { Name = name, BirthDate = birthDate };
                    people.Add(person);
                }
            }
            foreach (var person in peopleInfo)
            {
                string[] currentPerson = person.Split("-", StringSplitOptions.RemoveEmptyEntries);
                string parrentInfo = currentPerson[0].Trim();
                string childInfo = currentPerson[1].Trim();
                Person parent = FindPerson(people, parrentInfo);
                Person child = FindPerson(people, childInfo);
                parent.AddChild(child);
                child.AddParent(parent);
            }
            Person personToFind = FindPerson(people, personToFindInfo);
            Console.WriteLine(personToFind.Name + " " + personToFind.BirthDate);
            Console.WriteLine("Parents:");
            if (personToFind.Parents.Count > 0)
            {
                Console.WriteLine(string.Join(Environment.NewLine, personToFind.Parents.Select(x => x.Name + " " + x.BirthDate)));
            }
            Console.WriteLine("Children:");
            if (personToFind.Children.Count > 0)
            {
                Console.WriteLine(string.Join(Environment.NewLine, personToFind.Children.Select(x => x.Name + " " + x.BirthDate)));
            }
        }
        private static Person FindPerson(List<Person> people, string personInfo)
        {
            if (personInfo.Contains("/"))
            {
                return people.Find(x => x.BirthDate == personInfo);
            }
            else
            {
                return people.Find(x => x.Name == personInfo);
            }
        }
    }
}
