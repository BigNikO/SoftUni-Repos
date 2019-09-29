using System;

namespace Exe15BalancedBrackets
{
    class BalancedBrackets
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            string[] strings = new string[lines];
            bool check = false;
            for (int i = 0; i < lines; i++)
            {
                string line = Console.ReadLine();
                if (line == "(")
                {
                    if (check)
                    {
                        Console.WriteLine("UNBALANCED");
                        return;
                    }
                    check = true;
                }
                if (line == ")")
                {
                    if (!check)
                    {
                        Console.WriteLine("UNBALANCED");
                        return;
                    }
                    check = false;
                }             
            }
            if (!check)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }           
    }
}
