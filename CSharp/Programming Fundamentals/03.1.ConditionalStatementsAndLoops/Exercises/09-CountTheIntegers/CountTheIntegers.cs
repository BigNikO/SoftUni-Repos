namespace Ex9CountTheIntegers
{
    using System;
    class CountTheIntegers
    {
        static void Main(string[] args)
        {

            int intCheck;
            var theThext = Console.ReadLine();
            int.TryParse(theThext, out intCheck);
            int counter = 0;
            while (intCheck != 0)
            {
                counter++;
                theThext = Console.ReadLine();
                int.TryParse(theThext, out intCheck);
            }
            Console.WriteLine(counter);
        }
    }
}
