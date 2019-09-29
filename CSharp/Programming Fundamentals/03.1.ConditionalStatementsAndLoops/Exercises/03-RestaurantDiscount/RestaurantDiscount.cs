namespace Ex3RestaurantDiscount
{
    using System;
    class RestaurantDiscount
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();
            string hall = "Small Hall";
            double discount = 0.05;
            double priceHall = 2500;
            double pricePackage = 500;
            double totalPrice;
            if (groupSize <= 120)
            {
                if (package == "Gold")
                {
                    discount = 0.1;
                    pricePackage = 750;
                }
                if (package == "Platinum")
                {
                    discount = 0.15;
                    pricePackage = 1000;
                }

                if(groupSize>50 && groupSize<=100)
                {
                    priceHall = 5000;
                    hall = "Terrace";
                }
                else if(groupSize>100)
                {
                    priceHall = 7500;
                    hall = "Great Hall";
                }
                totalPrice = priceHall + pricePackage - (priceHall + pricePackage) * discount;
                Console.WriteLine($"We can offer you the {hall}");
                Console.WriteLine($"The price per person is {totalPrice/groupSize:f2}$");
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }

        }
    }
}
