using System;
using System.Linq;

namespace OpinionPoll
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Person[] people = new Person[n];

            for (int i = 0; i < n; i++)
            {
                string[] personInfo = Console.ReadLine().Split();
                Person person = new Person();
                person.Name = personInfo[0];
                person.Age = int.Parse(personInfo[1]);
                people[i] = person;
            }

            people = people
                .Where(x => x.Age > 30)
                .OrderBy(x => x.Name)
                .ToArray();

            foreach (var person in people)
            {
                Console.WriteLine(person.Name + " - " + person.Age);
            }
        }


    }
}
