using System;

namespace Ex1SoftUniReception
{
    class SoftUniReception
    {
        static void Main(string[] args)
        {
            int employeeOne = int.Parse(Console.ReadLine());
            int employeeTwo = int.Parse(Console.ReadLine());
            int employeeThree = int.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            int time = 0;
            while (studentsCount>0)
            {
                time++;
                if (time%4!=0)
                {
                    studentsCount -= (employeeOne + employeeThree + employeeTwo);                   
                }                
            }                    
            Console.WriteLine($"Time needed: {time}h.");
        }
    }
}
