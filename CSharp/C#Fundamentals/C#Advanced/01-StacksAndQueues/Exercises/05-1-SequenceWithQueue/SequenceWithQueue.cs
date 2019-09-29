using System;
using System.Collections.Generic;
using System.Text;

namespace Ex5SequenceWithQueue
{
    class SequenceWithQueue
    {
        static void Main(string[] args)
        {
            long firstNumber = long.Parse(Console.ReadLine());
            StringBuilder result = new StringBuilder();
            Queue<long> numbers = new Queue<long>();
            numbers.Enqueue(firstNumber);
            for (int i = 1; i <= 50; i++)
            {
                long sum = numbers.Peek();
                numbers.Enqueue(sum + 1);
                numbers.Enqueue(2 * sum + 1);
                numbers.Enqueue(sum + 2);
                result.Append(numbers.Dequeue() + " ");
            }
            Console.WriteLine(result);
        }

    }
}
