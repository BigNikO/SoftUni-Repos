namespace Ex8CaloriesCounter
{
    using System;
    class CaloriesCounter
    {
        static void Main(string[] args)
        {
            int calories = 0;
            int numberOfIngredients = int.Parse(Console.ReadLine());
            for (int i = 1; i <= numberOfIngredients; i++)
            {
                string ingredient = Console.ReadLine();
                ingredient = ingredient.ToLower();
                switch (ingredient)
                {
                    case ("cheese"):
                        calories += 500;
                        break;
                    case ("tomato sauce"):
                        calories += 150;
                        break;
                    case ("salami"):
                        calories += 600;
                        break;
                    case ("pepper"):
                        calories += 50;
                        break;
                }
            }
            Console.WriteLine($"Total calories: {calories}");
        }
    }
}
