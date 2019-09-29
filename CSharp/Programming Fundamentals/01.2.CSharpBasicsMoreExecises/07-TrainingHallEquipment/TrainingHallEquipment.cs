using System;

namespace Ex7TrainingHallEquipment
{
    class TrainingHallEquipment
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double startBudget = budget;
            byte itemstoBuy = byte.Parse(Console.ReadLine());
            for (int i = 0; i < itemstoBuy; i++)
            {
                string itemName = Console.ReadLine();
                double itemPrice = double.Parse(Console.ReadLine());
                int itemCount = int.Parse(Console.ReadLine());
                if (itemCount>1)
                {
                    itemName += "s";
                }
                Console.WriteLine($"Adding {itemCount} {itemName} to cart.");
                budget -= itemPrice*(double)itemCount;
            }
            if (budget>=0)
            {
                Console.WriteLine($"Subtotal: ${startBudget-budget:f2}");
                Console.WriteLine($"Money left: ${budget:f2}");
            }
            else
            {
                Console.WriteLine($"Subtotal: ${startBudget - budget:f2}");
                Console.WriteLine($"Not enough. We need ${Math.Abs(budget):f2} more.");
            }
        }
    }
}
