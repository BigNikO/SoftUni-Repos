using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab2AverageStudentGrades
{
    class AverageStudentGrades
    {
        static void Main(string[] args)
        {
            int inputLines = int.Parse(Console.ReadLine());

            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();

            for (int i = 0; i < inputLines; i++)
            {
                string[] studentAndGrade = Console.ReadLine().Split();
                if (!students.ContainsKey(studentAndGrade[0]))
                {
                    students.Add(studentAndGrade[0], new List<double> { double.Parse(studentAndGrade[1]) });
                }
                else
                {
                    students[studentAndGrade[0]].Add(double.Parse(studentAndGrade[1]));
                }
            }

            foreach (var student in students)
            {
                Console.WriteLine($"{student.Key} -> {string.Join(" ", student.Value.Select(x => $"{x:F2}"))}"
                     + $" (avg: {student.Value.Average():F2})");
            }
        }
    }
}
