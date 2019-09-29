using System;
using System.Collections.Generic;
using System.Text;

namespace Google
{
    public class Company
    {

        public Company(string name, string department, double salary)
        {
            this.Name = name;
            this.Department = department;
            this.Salary = salary;
        }
        public string Name { get; private set; }
        public string Department { get; private set; }
        public double Salary { get; private set; }
    }
}
