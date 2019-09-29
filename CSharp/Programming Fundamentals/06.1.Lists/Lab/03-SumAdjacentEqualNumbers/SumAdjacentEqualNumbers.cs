using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab3SumAdjacentEqualNumbers
{
    class SumAdjacentEqualNumbers
    {
        static void Main(string[] args)
        {
            string[] inputLine = Console.ReadLine().Split(' ');
            List<double> numbers = inputLine.Select(double.Parse).ToList();
            for (int i = 0; i < numbers.Count-1; i++)
            {
                if (i >= 0 && numbers[i] == numbers[i + 1])
                {
                    numbers[i+1] *= 2;
                    numbers.RemoveAt(i);
                    i = i - 2;    
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}

//3.	Sum Adjacent Equal Numbers
//Write a program to sum all adjacent equal numbers in a list of decimal numbers, starting from left to right.
//	After two numbers are summed, the obtained result could be equal to some of its neighbors and should be summed as well (see the examples below).
//	Always sum the leftmost two equal neighbors(if several couples of equal neighbors are available).
//Examples
//Input   Output Explanation
//3 3 6 1	12 1	3 3 6 1  6 6 1  12 1
//8 2 2  6 4 8 16	16 8 16   	8 2 2 4 8 16  8 4 4 8 16   8 8  8  16  16 8 16
//5 4 2 1 1 4	5 8 4	5 4 2 1 1 4  5 4 2 2 4  5 4 4 4  5 8 4
//Hints
//1.	Read the input and parse it to list of numbers.
//2.	Find the leftmost two adjacent equal cells.
//3.	Replace them with their sum.
//4.	Repeat (1) and(2) until no two equal adjacent cells survive.
//5.	Print the processed list of numbers.
