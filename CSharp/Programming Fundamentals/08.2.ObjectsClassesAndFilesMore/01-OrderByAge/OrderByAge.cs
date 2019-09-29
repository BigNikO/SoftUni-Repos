using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex1OrderByAge
{
    class Person
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }
    }
    class OrderByAge
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();
            while (true)
            {
                string[] input = Console.ReadLine().Split();
                if (input[0] == "End")
                    break;
                string name = input[0];
                string iD = input[1];
                int age = int.Parse(input[2]);
                Person person = new Person();
                person.Name = name;
                person.ID = iD;
                person.Age = age;
                persons.Add(person);
            }
            foreach (var person in persons.OrderBy(x=>x.Age))
            {
                Console.WriteLine($"{person.Name} with ID: {person.ID} is {person.Age} years old.");
            }
        }
    }
}
