using System;

namespace Lab0Tests
{
    class Tests
    {
        static void Main(string[] args)
        {
            string[] days = { "Monday", "Thuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            int day = int.Parse(Console.ReadLine());

            if (day >= 1 && day <= 7)
                Console.WriteLine(days[day - 1]);
            else
                Console.WriteLine("Invalid day!");

        }
    }
}
