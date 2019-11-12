namespace CoolStack
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var stack = new CoolStack(1);
            System.Console.WriteLine(stack.Count);

            stack.Push(2);
            stack.Push(3);
            stack.Push(4);

            System.Console.WriteLine(stack.Count == 3);

            int value = (int)stack.Pop();
            System.Console.WriteLine(value == 4);
            System.Console.WriteLine(stack.Count == 2);
            stack.ForEach(x => System.Console.WriteLine(x));
        }
    }
}
