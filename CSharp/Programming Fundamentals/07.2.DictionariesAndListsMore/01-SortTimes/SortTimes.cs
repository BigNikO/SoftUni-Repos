using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex1SortTimes
{
    class SortTimes
    {
        static void Main(string[] args)
        {
            List<String> times = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).ToList();
            string result = string.Join(", ",times.OrderBy(x=>x.Split(':')[0]).ThenBy(x=>x.Split(':')[1]));
            Console.WriteLine(result);
        }
    }
}
