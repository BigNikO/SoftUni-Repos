using System;

namespace DateModifier
{
    public class StartUp
    {
        public static void Main()
        {
            var dateModifier = new DateModifier();
            Console.WriteLine(Math.Abs(dateModifier.CalculateDaysDifference(Console.ReadLine(), Console.ReadLine())));
        }
    }
}
