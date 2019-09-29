using System;

namespace DateModifier
{
    class StartUp
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(DateModifier.GetDaysBetweenTowDates(Console.ReadLine(), Console.ReadLine()));
        }
    }
}
