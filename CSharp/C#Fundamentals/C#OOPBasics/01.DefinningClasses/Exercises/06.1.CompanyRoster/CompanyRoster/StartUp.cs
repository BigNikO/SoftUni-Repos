using System;
using System.Collections.Generic;
using System.Linq;

namespace CompanyRoster
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int numberOfEmployees = int.Parse(Console.ReadLine());

            var employees = new List<Employee>();

            for (int i = 0; i < numberOfEmployees; i++)
            {
                string[] employeeInfo = Console.ReadLine().Split();

                string name = employeeInfo[0];
                decimal salary = decimal.Parse(employeeInfo[1]);
                string position = employeeInfo[2];
                string department = employeeInfo[3];
                Employee employee = new Employee(name, salary, position, department);

                if (employeeInfo.Length == 5)
                {
                    if (employeeInfo[4].Contains("@"))
                    {
                        employee.Email = employeeInfo[4];
                    }
                    else
                    {
                        employee.Age = int.Parse(employeeInfo[4]);
                    }
                }
                if (employeeInfo.Length == 6)
                {
                    employee.Email = employeeInfo[4];
                    employee.Age = int.Parse(employeeInfo[5]);
                }
                employees.Add(employee);
            }

            var result = employees
                .GroupBy(e => e.Department)
                .Select(e => new
                {
                    Department = e.Key,
                    AverageSalary = e.Average(emp => emp.Salary),
                    Employees = e.OrderByDescending(emp => emp.Salary)
                })
                .OrderByDescending(e => e.AverageSalary)
                .FirstOrDefault();

            Console.WriteLine($"Highest Average Salary: {result.Department}");

            foreach (var employee in result.Employees)
            {
                Console.WriteLine($"{employee.Name} {employee.Salary:F2} {employee.Email} {employee.Age}");
            }
        }
    }
}
