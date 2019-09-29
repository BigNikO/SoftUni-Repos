using System;

namespace Ex1RageExpenses
{
    class RageExpenses
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());
            double headsetCrashes = 0d;
            double mouseCrashes = 0d;
            double keyboardCrashes = 0d;
            double displayCrashes = 0d;
            double totalExpenses = 0.0;
            for (int i = 1; i <= lostGames; i++)
            {
                if (i%2==0)
                {
                    headsetCrashes++;
                }
                if (i%3==0)
                {
                    mouseCrashes++;
                }
                if (i%2==0&&i%3==0)
                {
                    keyboardCrashes++;
                    if (keyboardCrashes % 2 == 0 && keyboardCrashes != 0)
                    {
                        displayCrashes++;
                    }
                }              
            }
            totalExpenses = headsetCrashes * headsetPrice + 
                mouseCrashes * mousePrice + 
                keyboardCrashes * keyboardPrice + 
                displayCrashes * displayPrice;
            Console.WriteLine($"Rage expenses: {totalExpenses:f2} lv.");
        }
    }
}
