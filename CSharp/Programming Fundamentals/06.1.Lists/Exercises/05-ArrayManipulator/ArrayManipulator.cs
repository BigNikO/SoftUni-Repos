using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex5ArrayManipulator
{
    class ArrayManipulator
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            while (true)
            {
                string[] command = Console.ReadLine()
                    .Split(' ')
                    .ToArray();
                if (command[0] == "add")
                {
                    Add(numbers, int.Parse(command[2]), int.Parse(command[1]));
                }
                else if (command[0] == "addMany")
                {
                    string[] elements = new string[command.Length - 2];
                    for (int i = 0; i < command.Length-2; i++)
                    {
                        elements[i] = command[i + 2];
                    }
                    AddMany(numbers, elements, int.Parse(command[1]));
                }
                else if (command[0] == "shift")
                {
                    Shift(numbers, int.Parse(command[1]));
                }
                else if (command[0] == "contains")
                {
                    Contains(numbers, int.Parse(command[1]));
                }
                else if (command[0] == "remove")
                {
                    Remove(numbers, int.Parse(command[1]));
                }
                else if (command[0] == "sumPairs")
                {
                    SumPairs(numbers);
                }
                else
                {
                    Console.WriteLine("[" + string.Join(", ", numbers) + "]");
                    break;
                }
            }
        }
        static void Add(List<int> numbers, int number, int index)
        {
            numbers.Insert(index, number);
        }

        static void AddMany(List<int> numbers, string[] elements, int index)
        {
            for (int i = 0; i < elements.Length; i++)
            {
                numbers.Insert(index+i, int.Parse(elements[i]));
            }
        }

        static void Contains(List<int> numbers, int number)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == number)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
            Console.WriteLine(-1);
        }

        static void Shift(List<int> numbers, int positions)
        {
            for (int i = 0; i < positions; i++)
            {
                numbers.Add(numbers[0]);
                numbers.RemoveAt(0);
            }
        }

        static void Remove(List<int> numbers, int index)
        {
            numbers.RemoveAt(index);
        }
        static void SumPairs(List<int> numbers)
        {
            int counter = numbers.Count;
            for (int i = 0; i < counter; i+=2)
            {
                if (i + 1 != counter)
                {
                    numbers.Add(numbers[i] + numbers[i + 1]);
                }
                else
                {
                    numbers.Add(numbers[i]);
                }

            }
            for (int i = counter-1; i >=0; i--)
            {
                numbers.RemoveAt(i);
            }
        }
    }
}
