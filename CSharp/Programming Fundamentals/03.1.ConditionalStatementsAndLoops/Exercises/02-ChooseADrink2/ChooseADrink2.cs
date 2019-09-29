using System;

namespace Ex2ChooseADrink2
{
    class ChooseADrink2
    {
        static void Main(string[] args)
        {
            string proffesion = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            switch (proffesion)
            {
                case ("Athlete"):
                    Console.WriteLine($"The {proffesion} has to pay {quantity*0.7:f2}.");
                    break;
                case ("Businessman"):
                case ("Businesswoman"):
                    Console.WriteLine($"The {proffesion} has to pay {quantity * 1.0:f2}.");
                    break;
                case ("SoftUni Student"):
                    Console.WriteLine($"The {proffesion} has to pay {quantity * 1.7:f2}.");
                    break;
                default:
                    Console.WriteLine($"The {proffesion} has to pay {quantity * 1.2:f2}.");
                    break;
            }
        }
    }
}
