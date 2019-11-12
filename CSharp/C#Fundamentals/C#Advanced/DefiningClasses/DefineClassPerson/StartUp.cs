namespace DefiningClasses
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var family = new Family();
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var personDetails = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                var member = new Person(personDetails[0], int.Parse(personDetails[1]));
                family.AddMember(member);
            }

            var oldestMember = family.GetOldestMember();
            family.People.Where(p => p.Age > 30).OrderBy(p => p.Name).ToList().ForEach(x => Console.WriteLine($"{x.Name} - {x.Age}"));
            Console.WriteLine($"{oldestMember.Name} {oldestMember.Age}");
        }
    }
}
