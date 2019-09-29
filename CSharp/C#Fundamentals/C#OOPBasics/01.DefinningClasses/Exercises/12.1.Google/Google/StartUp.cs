using System;
using System.Collections.Generic;
using System.Linq;

namespace Google
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Dictionary<string, Person> people = new Dictionary<string, Person>();

            string input;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] personInfo = input.Split();

                if (!people.ContainsKey(personInfo[0]))
                {
                    people.Add(personInfo[0], new Person());
                }

                Person person = people[personInfo[0]];

                if (personInfo[1] == "company")
                {
                    person.Company = new Company(personInfo[2], personInfo[3], double.Parse(personInfo[4]));
                }

                if (personInfo[1] == "car")
                {
                    person.Car = new Car(personInfo[2], personInfo[3]);
                }

                if (personInfo[1] == "pokemon")
                {
                    person.Pokemon.Add(new Pokemon(personInfo[2], personInfo[3]));
                }

                if (personInfo[1] == "parents")
                {
                    person.Parents.Add(new Parent(personInfo[2], personInfo[3]));
                }

                if (personInfo[1] == "children")
                {
                    person.Children.Add(new Child(personInfo[2], personInfo[3]));
                }

                people[personInfo[0]] = person;
            }
            string printName = Console.ReadLine();
            Console.WriteLine(printName);
            people[printName].PrintInformation();
        }
    }
}
