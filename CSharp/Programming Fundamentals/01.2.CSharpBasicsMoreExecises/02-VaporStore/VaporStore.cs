using System;

namespace Ex2VaporStore
{
    class VaporStore
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            double startMoney = money;
            while (true)
            {
                string game = Console.ReadLine();
                if (game == "Game Time")
                {
                    break;
                }
                else if (game== "OutFall 4")
                {
                    money -= 39.99;
                    if (money==0)
                    {
                        Console.WriteLine("Out of money!");
                        return;
                    }
                    else if (money<0)
                    {
                        Console.WriteLine("Too Expensive");
                        money += 39.99;
                    }
                    else
                    {
                        Console.WriteLine("Bought OutFall 4");
                    }
                }
                else if (game == "CS: OG")
                {
                    money -= 15.99;
                    if (money == 0)
                    {
                        Console.WriteLine("Out of money!");
                        return;
                    }
                    else if (money < 0)
                    {
                        Console.WriteLine("Too Expensive");
                        money += 15.99;
                    }
                    else
                    {
                        Console.WriteLine("Bought CS: OG");
                    }
                }
                else if (game == "Zplinter Zell")
                {
                    money -= 19.99;
                    if (money == 0)
                    {
                        Console.WriteLine("Out of money!");
                        return;
                    }
                    else if (money < 0)
                    {
                        Console.WriteLine("Too Expensive");
                        money += 19.99;
                    }
                    else
                    {
                        Console.WriteLine("Bought Zplinter Zell");
                    }
                }
                else if (game == "Honored 2")
                {
                    money -= 59.99;
                    if (money == 0)
                    {
                        Console.WriteLine("Out of money!");
                        return;
                    }
                    else if (money < 0)
                    {
                        Console.WriteLine("Too Expensive");
                        money += 59.99;
                    }
                    else
                    {
                        Console.WriteLine("Bought Honored 2");
                    }
                }
                else if (game == "RoverWatch")
                {
                    money -= 29.99;
                    if (money == 0)
                    {
                        Console.WriteLine("Out of money!");
                        return;
                    }
                    else if (money < 0)
                    {
                        Console.WriteLine("Too Expensive");
                        money += 29.99;
                    }
                    else
                    {
                        Console.WriteLine("Bought RoverWatch");
                    }
                }
                else if (game == "RoverWatch Origins Edition")
                {
                    money -= 39.99;
                    if (money == 0)
                    {
                        Console.WriteLine("Out of money!");
                        return;
                    }
                    else if (money < 0)
                    {
                        Console.WriteLine("Too Expensive");
                        money += 39.99;
                    }
                    else
                    {
                        Console.WriteLine("Bought RoverWatch Origins Edition");
                    }
                }
                else
                {
                    Console.WriteLine("Not Found");
                }
                

            }
            Console.WriteLine($"Total spent: ${startMoney - money:f2}. Remaining: ${money:f2}");
        }
    }
}
