using System;

namespace Ex1ChoseADrink
{
    class ChoseADrink
    {
        static void Main(string[] args)
        {
            string proffesion = Console.ReadLine();
            switch(proffesion)
            {
                case ("Athlete"):
                    Console.WriteLine("Water");
                    break;
                case ("Businessman"):
                case ("Businesswoman"):
                    Console.WriteLine("Coffee");
                    break;
                case ("SoftUni Student"):
                    Console.WriteLine("Beer");
                    break;
                default:
                    Console.WriteLine("tea");
                    break;
            }
        }
    }
}
