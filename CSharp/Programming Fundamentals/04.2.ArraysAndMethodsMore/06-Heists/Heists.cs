using System;
using System.Linq;

namespace Ex6Heists
{
    class Heists
    {
        static void Main(string[] args)
        {
            ulong[] price = Console.ReadLine().Split(' ').Select(ulong.Parse).ToArray();           
            ulong jewelsEarn = 0;
            ulong goldEarn = 0;
            ulong expences = 0;
            for (int i = 0; i < 100; i++)
            {
                string[] lootHeist = Console.ReadLine().Split(' ');
                if (lootHeist[0] == "Jail" && lootHeist[1] == "Time")
                {
                    break;
                }
                expences += ulong.Parse(lootHeist[1]);
                string checkHeist = lootHeist[0];
                int countJewels = 0;
                int countGold = 0;
                for (int j = 0; j < checkHeist.Length; j++)
                {
                    if (checkHeist[j] ==  '%')
                    {
                        countJewels++;
                    }
                    else if (checkHeist[j] == '$')
                    {
                        countGold++;
                    }
                    
                }
                goldEarn += (ulong)countGold * price[1];
                jewelsEarn += (ulong)countJewels * price[0];
            }
            ulong totalEarn = goldEarn + jewelsEarn;
            if (totalEarn < expences)
            {
                Console.WriteLine($"Have to find another job. Lost: {expences - totalEarn}.");
            }
            else
            {
                Console.WriteLine($"Heists will continue. Total earnings: {totalEarn - expences}.");
            }

        }
    }
}
