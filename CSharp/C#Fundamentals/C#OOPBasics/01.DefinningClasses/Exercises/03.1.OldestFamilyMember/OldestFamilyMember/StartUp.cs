using System;
using System.Collections.Generic;

namespace OldestFamilyMember
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Family family = new Family();
            family.Members = new List<Person>();

            for (int i = 0; i < n; i++)
            {
                string[] personInfo = Console.ReadLine().Split();
                Person member = new Person();
                member.Name = personInfo[0];
                member.Age = int.Parse(personInfo[1]);
                family.AddMember(member);
            }

            Person oldestMember = new Person();
            oldestMember = family.GetOldestFamilyMember();

            Console.WriteLine($"{oldestMember.Name} {oldestMember.Age}");
        }
    }
}
