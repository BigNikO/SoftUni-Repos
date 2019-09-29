using System;

namespace Exe15NeighBoursFights
{
    class NeighBoursFights
    {
        static void Main(string[] args)
        {
            int hitsOfPesho = int.Parse(Console.ReadLine());
            int hitsOfGosho = int.Parse(Console.ReadLine());
            int defHealthPesho = 100;
            int defHealthGosho = 100;
            string winner;
            int i = 0;
            for (; ; )
            {

                if (i % 2 == 0)
                {
                    i++;
                    defHealthGosho -= hitsOfPesho;
                    if (defHealthGosho <= 0)
                    {
                        winner = "Pesho";
                        break;
                    }
                    else if (defHealthPesho <= 0)
                    {
                        winner = "Gosho";
                        break;
                    }
                    Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {defHealthGosho} health.");
                }
                else
                {
                    i++;
                    defHealthPesho -= hitsOfGosho;
                    if (defHealthGosho <= 0)
                    {
                        winner = "Pesho";
                        break;
                    }
                    else if (defHealthPesho <= 0)
                    {
                        winner = "Gosho";
                        break;
                    }
                    Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {defHealthPesho} health.");
                }
                if (i % 3 == 0)
                {
                    defHealthGosho += 10;
                    defHealthPesho += 10;
                }
            }
            Console.WriteLine($"{winner} won in {i}th round.");
        }
    }
}
