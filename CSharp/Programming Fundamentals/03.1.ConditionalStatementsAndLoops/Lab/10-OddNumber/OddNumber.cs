
namespace Taskk10OddNumber
{
    using System;
    class OddNumber
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int check = 0;
            if ((number % 2) != 0)
            {
                Console.WriteLine("The number is: {0}", Math.Abs(number));
            }
            while ((number % 2) == 0)
            {
                Console.WriteLine("Please write an odd number.");
                number = int.Parse(Console.ReadLine());
                check++;
            }
            if (check > 0)
                Console.WriteLine("The number is: {0}", Math.Abs(number));
            {

            }
        }
    }
}
