using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Ex8Mentor
{
    public class Student
    {
        public string Name;
        public List<DateTime> Dates;
        public List<string> Comments;

        public Student(string name)
        {
            Name = name;
            Dates = new List<DateTime>();
            Comments = new List<string>();
        }
    }
    class Mentor
    {
        public static void Main()
        {
            List<Student> students = new List<Student>();
            string InputLine;
            while ((InputLine = Console.ReadLine()) != "end of dates")
            {
                Student student = students.FirstOrDefault(name => name.Name == InputLine.Split(' ')[0]);
                if (student == null)
                {
                    student = new Student(InputLine.Split(' ')[0]);
                    students.Add(student);
                }
                student.Dates.AddRange(InputLine.Split(' ', ',')
                    .Skip(1)
                    .Select(date => DateTime.ParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture)));
            }
            while ((InputLine = Console.ReadLine()) != "end of comments")
            {
                Student student = students.FirstOrDefault(name => name.Name == InputLine.Split('-')[0]);
                student?.Comments.Add(InputLine.Split('-')[1]);
            }
            foreach (var student in students.OrderBy(names => names.Name))
            {
                Console.WriteLine(student.Name);
                Console.WriteLine("Comments:");
                foreach (var comment in student.Comments)
                {
                    Console.WriteLine($"- {comment}");
                }
                Console.WriteLine("Dates attended:");
                foreach (var date in student.Dates.OrderBy(d => d))
                {
                    Console.WriteLine($"-- {date.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture)}");
                }
            }
        }
    }
}


