
namespace LinkedList
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var linkedList = new CoolLinkedList();

            linkedList.AddFirst(5);
            linkedList.AddFirst(10);
            linkedList.AddFirst(15);
            Console.WriteLine(linkedList.Count == 3);
            linkedList.AddLast(20);
            linkedList.AddLast(30);
            linkedList.AddLast(40);
            Console.WriteLine(linkedList.Count == 6);
            var first = linkedList.RemoveFirst();
            Console.WriteLine(linkedList.Count == 5);
            var last = linkedList.RemoveLast();
            Console.WriteLine(linkedList.Count == 4);
            Console.WriteLine((int)first==15);
            Console.WriteLine((int)last==40);
            linkedList.ForEach(x => Console.Write($"<{x}>"));
            Console.WriteLine();
            Console.WriteLine(String.Join("<->", linkedList.ToArray().Select(x => (int)x).ToArray()));
        }
    }
}
