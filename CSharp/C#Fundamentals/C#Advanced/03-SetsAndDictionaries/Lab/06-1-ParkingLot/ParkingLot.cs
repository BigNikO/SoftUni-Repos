using System;
using System.Collections.Generic;

namespace Lab6ParkingLot
{
    class ParkingLot
    {
        static void Main(string[] args)
        {
            HashSet<string> inside = new HashSet<string>();
            string[] inputLines;

            while ((inputLines = Console.ReadLine().Split(", "))[0] != "END")
            {
                if (inputLines[0] == "IN")
                {
                    inside.Add(inputLines[1]);
                }
                else
                {
                    inside.Remove(inputLines[1]);
                }
            }
            if (inside.Count!=0)
            {
                Console.WriteLine(string.Join(Environment.NewLine, inside));
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
