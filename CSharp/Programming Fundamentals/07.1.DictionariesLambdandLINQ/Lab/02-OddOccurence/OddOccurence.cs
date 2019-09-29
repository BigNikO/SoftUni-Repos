using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab2OddOccurence
{
    class OddOccurence
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().ToLower().Split(' ').ToArray();
            var counts = new Dictionary<string, int>();
            foreach (var word in words)
            {
                if (counts.ContainsKey(word))
                {
                    counts[word]++;
                }
                else
                {
                    counts[word] = 1;
                }
            }
            List<string> result = new List<string>();
            foreach (var item in counts)
            {
                if (item.Value%2!=0)
                {
                    result.Add(item.Key);                
                }
            }
            Console.WriteLine(string.Join(", ",result));
        }
    }
}
