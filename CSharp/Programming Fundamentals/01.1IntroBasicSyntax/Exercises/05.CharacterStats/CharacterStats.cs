
namespace CharacterStats
{
    using System;
    class CharacterStats
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int currentHealth = int.Parse(Console.ReadLine());
            int maxHealth = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());

            string energy = new String('|', currentEnergy);
            string energyMiss = new String('.', maxEnergy-currentEnergy);
            string health = new String('|', currentHealth);
            string healthMiss = new String('.', maxHealth-currentHealth);

            Console.WriteLine("Name: " + name);
            Console.WriteLine("Health: |" + health + healthMiss + "|");
            Console.WriteLine("Energy: |" + energy + energyMiss + "|");

           
        }
    }
}
