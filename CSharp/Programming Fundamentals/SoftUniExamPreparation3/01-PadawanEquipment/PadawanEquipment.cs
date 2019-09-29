using System;
namespace Pb1PadawanEquipment
{
    class PadawanEquipment
    {
        static void Main(string[] args)
        {
            double amountOfMoney = double.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            double sabresPrice = double.Parse(Console.ReadLine());
            double robesPrice = double.Parse(Console.ReadLine());
            double beltsPrice = double.Parse(Console.ReadLine());
            int sabres = (int)Math.Ceiling(studentsCount *10.0 / 100 + studentsCount);
            int belts = studentsCount-studentsCount/6;
            int robes = studentsCount;
            double totalPrice = sabres * sabresPrice + belts * beltsPrice + robes * robesPrice;
            if (totalPrice<=amountOfMoney)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {totalPrice-amountOfMoney:f2}lv more.");
            }
        }
    }
}
