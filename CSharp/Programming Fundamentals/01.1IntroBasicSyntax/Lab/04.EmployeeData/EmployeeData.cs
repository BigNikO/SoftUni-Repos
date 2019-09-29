namespace EmployeeData
{
    using System;
    class EmployeeData
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            int employeeID = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());

            Console.WriteLine(
                "Name: {0}" + System.Environment.NewLine +
                "Age: {1}" + System.Environment.NewLine +
                "Employee ID: {2:D8}" + System.Environment.NewLine +
                "Salary: {3:F2}", name, age, employeeID, salary
                );
        }
    }
}
