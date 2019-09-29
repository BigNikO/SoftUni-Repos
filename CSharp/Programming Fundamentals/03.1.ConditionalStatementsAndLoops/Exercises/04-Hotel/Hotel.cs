namespace Ex4Hotel
{
    using System;
    class Hotel
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nightsCount = int.Parse(Console.ReadLine());
            double studioPrice=0;
            double doublePrice=0;
            double suitePrice=0;
            switch (month)
            {
                case ("May"):
                    studioPrice = 50 * nightsCount;
                    doublePrice = 65 * nightsCount;
                    suitePrice = 75 * nightsCount;
                    if (nightsCount > 7)
                    {
                        studioPrice = 50 * (nightsCount) - 0.05 * 50 * (nightsCount);
                    }
                    break;
                case ("October"):
                    studioPrice = 50 * nightsCount;
                    doublePrice = 65 * nightsCount;
                    suitePrice = 75 * nightsCount;
                    if (nightsCount > 7)
                    {
                        studioPrice = 50 * (nightsCount-1) - 0.05 * 50 * (nightsCount-1);
                    }
                    break;
                case ("September"):
                    if (nightsCount > 7)
                    {
                        studioPrice = 60 * (nightsCount-1);
                        doublePrice = 72 * nightsCount;
                        suitePrice = 82 * nightsCount;
                        if (nightsCount > 14)
                        {
                            doublePrice = 72 * nightsCount - 0.1 * 72 * nightsCount;
                        }
                    }
                    else
                    {
                        studioPrice = 60 * nightsCount;
                        doublePrice = 72 * nightsCount;
                        suitePrice = 82 * nightsCount;
                    }
                    break;
                case ("June"):
                    studioPrice = 60 * nightsCount;
                    doublePrice = 72 * nightsCount;
                    suitePrice = 82 * nightsCount;
                    if (nightsCount > 14)
                    {
                        doublePrice = 72 * nightsCount - 0.1 * 72 * nightsCount;
                    }
                    break;
                case ("July"):
                case ("August"):
                case ("December"):
                    studioPrice = 68 * nightsCount;
                    doublePrice = 77 * nightsCount;
                    suitePrice = 89 * nightsCount;
                    if (nightsCount > 14)
                    {
                        suitePrice = 89 * nightsCount - 0.15 * 89 * nightsCount;
                    }
                    break;
            }
            Console.WriteLine($"Studio: {studioPrice:f2} lv.");
            Console.WriteLine($"Double: {doublePrice:f2} lv.");
            Console.WriteLine($"Suite: {suitePrice:f2} lv.");

        }
    }
}
