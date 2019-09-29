namespace Ex6IntervalOfNumbers
{
    using System;
    class CakeIngredients
    {
        static void Main(string[] args)
        {
            string ingredient = Console.ReadLine();
            int ingredientsCounter = 0;
            while (ingredient != "Bake!")
            {
                Console.WriteLine($"Adding ingredient {ingredient}.");
                ingredient = Console.ReadLine();
                ingredientsCounter++;
            }
            Console.WriteLine($"Preparing cake with {ingredientsCounter} ingredients.");
        }
    }
}
