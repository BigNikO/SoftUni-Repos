using System;

namespace Exe14BoatSimulator
{
    class BoatSimulator
    {
        static void Main(string[] args)
        {
            char firstBoatChar = char.Parse(Console.ReadLine());
            char secondBoatChar = char.Parse(Console.ReadLine());
            int movesOne = 0;
            int MovesTwo = 0;
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                string moves = Console.ReadLine();
                if (moves == "UPGRADE")
                {
                    firstBoatChar = (char)(firstBoatChar + 3);
                    secondBoatChar = (char)(secondBoatChar + 3);
                }
                else if (i%2!=0)
                {
                    movesOne += moves.Length;
                }
                else
                {
                    MovesTwo += moves.Length;
                }
                if (movesOne>=50||MovesTwo>=50)
                {
                    break;
                }
            }
            if (movesOne>MovesTwo)
            {
                Console.WriteLine(firstBoatChar);
            }
            else
            {
                Console.WriteLine(secondBoatChar);
            }
        }
    }
}
