
namespace Task2BackOn30Minutes
{
    using System;
    class BackOn30Minutes
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            minutes = minutes + 30;
            if (minutes > 59)
            {
                hours = hours + 1;
                minutes = minutes - 60;
                if (hours==24)
                {
                    hours = 0;
                }
            }
            if (minutes<10)
            {
                Console.WriteLine("{0}:{1:d2}", hours, minutes);
            }
            else
            {
                Console.WriteLine("{0}:{1}", hours, minutes);
            }
        }
    }
}
