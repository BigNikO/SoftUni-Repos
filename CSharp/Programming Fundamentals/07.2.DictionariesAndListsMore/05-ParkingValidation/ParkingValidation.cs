using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex5ParkingValidation
{
    class ParkingValidation
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> parkingUsers = new Dictionary<string, string>();
            int numberOfCommands = int.Parse(Console.ReadLine());
            for (int j = 0; j < numberOfCommands; j++)
            {
                string[] input = Console.ReadLine().Split();
                if (input[0] == "register")
                {
                    string licensePlateNumber = input[2];
                    try
                    {
                        int exception = 0;

                        string username = input[1];
                        if (!parkingUsers.ContainsKey(username))
                        {
                            for (int i = 0; i < licensePlateNumber.Length; i++)
                            {
                                if (i >= 2 && i < licensePlateNumber.Length - 2)
                                {
                                    exception = int.Parse(licensePlateNumber[i].ToString());
                                }
                                else if (Char.IsLower(licensePlateNumber[i]) || licensePlateNumber.Length > 8)
                                {
                                    exception = int.Parse(input[0]);
                                }
                            }
                            if (!parkingUsers.Values.ToList().Contains(licensePlateNumber))
                            {
                                parkingUsers[username] = licensePlateNumber;
                                Console.WriteLine($"{username} registered {licensePlateNumber} successfully");
                            }
                            else
                            {
                                Console.WriteLine($"ERROR: license plate {licensePlateNumber} is busy");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"ERROR: already registered with plate number {parkingUsers[username]}");
                        }
                    }
                    catch (Exception)
                    {

                        Console.WriteLine($"ERROR: invalid license plate {licensePlateNumber}");
                    }
                }
                else
                {
                    string username = input[1];
                    if (!parkingUsers.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                    else
                    {
                        Console.WriteLine($"user {username} unregistered successfully");
                        parkingUsers.Remove(username);
                    }
                }
            }
            foreach (var username in parkingUsers)
            {
                Console.WriteLine($"{username.Key} => {username.Value}");
            }
        }
    }
}