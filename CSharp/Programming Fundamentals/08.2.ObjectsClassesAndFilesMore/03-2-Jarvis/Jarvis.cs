using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex3Jarvis.V2
{
    class Jarvis
    {
        public Head Head { get; set; }
        public Torso Torso { get; set; }
        public List<Arms> Arms { get; set; }
        public List<Legs> Legs { get; set; }
    }
    class Head
    {
        public int EnergyConsumption { get; set; }
        public int IQ { get; set; }
        public string Material { get; set; }
    }
    class Torso
    {
        public int EnergyConsumption { get; set; }
        public decimal ProcessorSize { get; set; }
        public string Material { get; set; }
    }
    class Arms
    {
        public int EnergyConsumption { get; set; }
        public int ArmsLenght { get; set; }
        public int Fingers { get; set; }
    }
    class Legs
    {
        public int EnergyConsumption { get; set; }
        public int Strenght { get; set; }
        public int Speed { get; set; }
    }

    class Jarvis
    {
        static void Main(string[] args)
        {
            Jarvis jarvis = new Jarvis();
            jarvis.Arms = new List<Arms>();
            jarvis.Legs = new List<Legs>();
            int headEnergy = int.MaxValue;
            int torsoEnergy = int.MaxValue;
            long Enery = long.Parse(Console.ReadLine());
            while (true)
            {
                string[] newComponent = Console.ReadLine().Split();
                if (newComponent[0] == "Assemble!")
                {
                    break;
                }
                string part = newComponent[0];
                int energyConsumption = int.Parse(newComponent[1]);
                string firstPropery = newComponent[2];
                string secondProperty = newComponent[3];
                if (part == "Head")
                {
                    Head head = new Head { EnergyConsumption = energyConsumption, IQ = int.Parse(firstPropery), Material = secondProperty };
                    if (energyConsumption <= headEnergy)
                    {
                        jarvis.Head = head;
                        headEnergy = energyConsumption;
                    }
                }
                else if (part == "Torso")
                {
                    Torso torso = new Torso { EnergyConsumption = energyConsumption, ProcessorSize = decimal.Parse(firstPropery), Material = secondProperty };
                    if (energyConsumption <= torsoEnergy)
                    {
                        jarvis.Torso = torso;
                        torsoEnergy = energyConsumption;
                    }
                }
                else if (part == "Arm")
                {
                    Arms arm = new Arms { EnergyConsumption = energyConsumption, ArmsLenght = int.Parse(firstPropery), Fingers = int.Parse(secondProperty) };
                    jarvis.Arms.Add(arm);
                }
                else if (part == "Leg")
                {
                    Legs leg = new Legs { EnergyConsumption = energyConsumption, Strenght = int.Parse(firstPropery), Speed = int.Parse(secondProperty) };
                    jarvis.Legs.Add(leg);
                }
            }
            try
            {
                long jarvisEnery = (jarvis.Head.EnergyConsumption + jarvis.Torso.EnergyConsumption +
                    jarvis.Arms.OrderBy(x => x.EnergyConsumption).Take(2).Sum(x => (long)x.EnergyConsumption) +
                    jarvis.Legs.OrderBy(x => x.EnergyConsumption).Take(2).Sum((x => (long)x.EnergyConsumption)));
                long checkException = jarvis.Arms[1].ArmsLenght + jarvis.Legs[1].EnergyConsumption;
                if (jarvisEnery <= Enery)
                {
                    // Head
                    Console.WriteLine("Jarvis:");
                    Console.WriteLine("#Head:");
                    Console.WriteLine($"###Energy consumption: {jarvis.Head.EnergyConsumption}");
                    Console.WriteLine($"###IQ: {jarvis.Head.IQ}");
                    Console.WriteLine($"###Skin material: {jarvis.Head.Material}");
                    // Torso                 
                    Console.WriteLine("#Torso:");
                    Console.WriteLine($"###Energy consumption: {jarvis.Torso.EnergyConsumption}");
                    Console.WriteLine($"###Processor size: {jarvis.Torso.ProcessorSize:f1}");
                    Console.WriteLine($"###Corpus material: {jarvis.Torso.Material}");
                    // Arms
                    foreach (var arm in jarvis.Arms.OrderBy(x => x.EnergyConsumption).Take(2))
                    {
                        Console.WriteLine("#Arm:");
                        Console.WriteLine($"###Energy consumption: {arm.EnergyConsumption}");
                        Console.WriteLine($"###Reach: {arm.ArmsLenght}");
                        Console.WriteLine($"###Fingers: {arm.Fingers}");
                    }
                    // Legs
                    foreach (var leg in jarvis.Legs.OrderBy(x => x.EnergyConsumption).Take(2))
                    {
                        Console.WriteLine("#Leg:");
                        Console.WriteLine($"###Energy consumption: {leg.EnergyConsumption}");
                        Console.WriteLine($"###Strength: {leg.Strenght}");
                        Console.WriteLine($"###Speed: {leg.Speed}");
                    }
                }
                else
                {
                    Console.WriteLine("We need more power!");
                }
            }
            catch
            {
                Console.WriteLine("We need more parts!");
            }
        }
    }
}
