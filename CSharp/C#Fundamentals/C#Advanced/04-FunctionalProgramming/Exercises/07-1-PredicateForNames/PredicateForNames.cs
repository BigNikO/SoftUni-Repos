using System;
using System.Linq;

namespace Ex7PredicateForNames {
    class PredicateForNames {
        static void Main (string[] args) {
            var pred = int.Parse(Console.ReadLine());
            Predicate<int> isGoodLength = length => length <= pred;
            Action<string[]> print = names => Console.WriteLine(String.Join(Environment.NewLine, names
                .Where(name=>isGoodLength(name.Length))));
            print(Console.ReadLine().Split());
        }
    }
}