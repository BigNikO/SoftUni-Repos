using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab2AppendList
{
    class AppendList
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine().Split('|',StringSplitOptions.RemoveEmptyEntries).ToList();
            List<int> result = new List<int>();
            for (int i = numbers.Count-1; i >= 0; i--)
            {
                List<int> reversedLists= numbers[i].Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

                for (int j = 0; j < reversedLists.Count; j++)
                {
                    result.Add(reversedLists[j]);
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}

//Write a program to append several lists of numbers.
//	Lists are separated by ‘|’.
//	Values are separated by spaces(‘ ’, one or several)
//	Order the lists from the last to the first, and their values from left to right.
//Examples
//Input   Output
//1 2 3 |4 5 6 |  7  8	7 8 4 5 6 1 2 3
//7 | 4  5|1 0| 2 5 |3	3 2 5 1 0 4 5 7
//1| 4 5 6 7  |  8 9	8 9 4 5 6 7 1
//Hints
//•	Create a new empty list for the results.
//•	Split the input by ‘|’ into array of tokens.
//•	Pass through each of the obtained tokens from right to left.
//o For each token, split it by space and append all non-empty tokens to the results.
//•	Print the results.
