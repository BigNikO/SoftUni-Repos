using System;
using System.Collections.Generic;

namespace Ex3ImmuneSystem
{
    class ImmuneSystem
    {
        static void Main(string[] args)
        {
            int health = int.Parse(Console.ReadLine());
            int startHealth = health;
            Dictionary<string, int> immuneSystem = new Dictionary<string, int>();
            while (true)
            {

                string virusName = Console.ReadLine();
                if (virusName=="end")
                {
                    break;
                }
                int virusStrenght = 0;

                for (int i = 0; i < virusName.Length; i++)
                {
                    virusStrenght += virusName[i];
                }
                virusStrenght = (int)((double)virusStrenght / 3.0);
                if (!immuneSystem.ContainsKey(virusName))
                {                   
                    immuneSystem[virusName] = (int)((double)virusName.Length * (double)virusStrenght);
                }
                else
                {
                    immuneSystem[virusName] = (int)((double)immuneSystem[virusName] / 3.0);
                }
                int timeToDefeat = immuneSystem[virusName];
                if (timeToDefeat>=health)
                {
                    Console.WriteLine($"Virus {virusName}: {virusStrenght} => {timeToDefeat} seconds");
                    Console.WriteLine("Immune System Defeated.");
                    return;
                }
                else
                {
                    int minutes = timeToDefeat / 60;
                    int seconds = timeToDefeat % 60;
                    health = health - timeToDefeat;
                    Console.WriteLine($"Virus {virusName}: {virusStrenght} => {timeToDefeat} seconds");
                    Console.WriteLine($"{virusName} defeated in {minutes}m {seconds}s.");
                    Console.WriteLine($"Remaining health: {health}");
                    health += health * 20 / 100;
                    if (health>startHealth)
                    {
                        health = startHealth;
                    }
                }
            }
            Console.WriteLine($"Final Health: {health}");
        }
    }
}
