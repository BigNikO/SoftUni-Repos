namespace BeverageLabels
{
    using System;
    class BeverageLabels
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double volume = int.Parse(Console.ReadLine());
            double energyContent = int.Parse(Console.ReadLine());
            double sugarContent = int.Parse(Console.ReadLine());

            double energy = (volume / 100) * energyContent;
            double sugar = (volume / 100) * sugarContent;

            Console.WriteLine("{0}ml {1}:"+  
                System.Environment.NewLine +
                "{2}kcal, {3}g ", volume, name, energy, sugar);
        }
    }
}
