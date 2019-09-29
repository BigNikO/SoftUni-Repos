using System;
using System.Linq;

namespace Ex5PizzaIngredients
{
    class PizzaIngredients
    {
        static void Main(string[] args)
        {
            string[] ingredients = Console.ReadLine().Split(' ');
            int length = int.Parse(Console.ReadLine());
            int counter = 0;
            string conclusion = "";
            for (int i = 0; i < ingredients.Length && counter<10; i++)
            {
                if (length == ingredients[i].Length)
                {
                    Console.WriteLine("Adding " + ingredients[i] + ".");
                    counter++;
                    if (counter>1)
                    {
                        conclusion += ", " +ingredients[i];
                    }
                    else
                    {
                        conclusion += ingredients[i];
                    }
                    
                }
            }
            Console.WriteLine("Made pizza with total of " + counter + " ingredients." 
                + Environment.NewLine +
                "The ingredients are: " + conclusion +".");
        }
    }
}
