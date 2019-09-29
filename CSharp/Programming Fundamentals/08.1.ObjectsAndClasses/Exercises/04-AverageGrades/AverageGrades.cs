using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex4AverageGrades
{
    class Student
    {
        public string Name { get; set; }
        public List<double> Grades { get; set; }
        public double AverageGrade { get { return Grades.Sum() / Grades.Count; } }
    }      
    class AverageGrades
    {
        static void Main(string[] args)
        {
            int numberOfStudents = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();
            for (int i = 0; i < numberOfStudents; i++)
            {
                List<string> student = Console.ReadLine().Split().ToList();
                students.Add(ReadStudent(student));
            }
            foreach (Student student in students
                .Where(x => x.AverageGrade >= 5)
                .OrderBy(x => x.Name)
                .ThenByDescending(x => x.AverageGrade))
            {
                Console.WriteLine("{0} -> {1:F2}", student.Name, student.AverageGrade);
            }
        }
        static Student ReadStudent(List<string> input)
        {
            Student student = new Student();
            student.Name = input[0];
            List<double> grades = new List<double>();
            foreach (var grade in input.Skip(1))
            {
                grades.Add(double.Parse(grade));
            }
            student.Grades = grades;
            return student;
        }
    }
}
