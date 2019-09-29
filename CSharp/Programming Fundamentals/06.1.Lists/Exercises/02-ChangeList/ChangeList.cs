using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex2ChangeList
{
    class ChangeList
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            String[] command = Console.ReadLine().Split(' ').ToArray();
            while (true)
            {
                if (command[0] == "Delete")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i]==int.Parse(command[1]))
                        {
                            numbers.RemoveAt(i);
                            i--;
                        }                       
                    }                    
                }
                else if (command[0] == "Insert")
                {
                    int pos = int.Parse(command[2]);
                    int number = int.Parse(command[1]);
                    numbers.Insert(pos, number);
                }
                else
                {
                    break;
                }
                command = Console.ReadLine().Split(' ').ToArray();
            }
            Print(command, numbers);

        }
        static void Print(string[] command, List<int> numbers)
        {
            if (command[0] == "Odd")
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] % 2 != 0)
                    {
                        Console.Write(numbers[i] + " ");
                    }
                }
            }
            else if(command[0] == "Even")
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] % 2 == 0)
                    {
                        Console.Write(numbers[i]);
                        if (i<numbers.Count-1)
                        {
                            Console.Write(" ");
                        }
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
