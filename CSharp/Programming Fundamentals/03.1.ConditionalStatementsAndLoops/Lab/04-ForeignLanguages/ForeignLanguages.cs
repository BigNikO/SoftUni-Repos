namespace Task4ForeignLanguages
{
    using System;
    class ForeignLanguages
    {
        static void Main(string[] args)
        {
            string language = Console.ReadLine();
            switch (language)
            {
                case ("USA"):
                    Console.WriteLine("English");
                    break;
                case ("Spain"):
                    Console.WriteLine("Spanish");
                    break;
                case ("Argentina"):
                    Console.WriteLine("Spanish");
                    break;
                case ("Mexico"):
                    Console.WriteLine("Spanish");
                    break;
                default:
                    Console.WriteLine("Unknown");
                    break;

            }
        }
    }
}
