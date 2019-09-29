using System;
using System.Collections.Generic;
using System.Linq;
namespace Ex7AndreyAndBillard
{
    class Client
    {
        public String Name { get; set; }
        public Dictionary<string, int> ProductAndQuantity { get; set; }
        public decimal Price { get; set; }
        public decimal Bill { get; set; }
    }
    class AndreyAndBillard
    {
        static void Main(string[] args)
        {
            Dictionary<string, decimal> entities = new Dictionary<string, decimal>();
            int length = int.Parse(Console.ReadLine());
            for (int i = 0; i < length; i++)
            {
                string[] inputProduct = Console.ReadLine().Split("-");
                if (entities.ContainsKey(inputProduct[0]))
                {
                    entities[inputProduct[0]] = decimal.Parse(inputProduct[1]);
                }
                else
                {
                    entities[inputProduct[0]] = decimal.Parse(inputProduct[1]);
                }
            }
            Dictionary<string, int> ProductAndQuantity = new Dictionary<string, int>();
            List<Client> clients = new List<Client>();
            while (true)
            {
                string[] inputClient = Console.ReadLine().Split(',', '-');
                Client client = new Client();
                if (inputClient[0] == "end of clients") { break; }
                else if (entities.ContainsKey(inputClient[1]))
                {
                    string name = inputClient[0];
                    string product = inputClient[1];
                    int quantity = int.Parse(inputClient[2]);
                    decimal price = entities[inputClient[1]];
                    decimal bill = quantity*price;

                    if (clients.Any(x => x.Name == name))
                    {
                        if (clients.Where(x => x.Name == name).First().ProductAndQuantity.ContainsKey(product))
                        {
                            var customer = clients.Where(x => x.Name == name).First();
                            customer.ProductAndQuantity[product] += quantity;
                            customer.Bill += bill;
                        }
                        else
                        {                          
                            var customer = clients.Where(x => x.Name == name).First();
                            customer.ProductAndQuantity[product] = quantity;
                            customer.Bill += bill;
                        }
                    }
                    else
                    {
                        client.Name = name;
                        client.ProductAndQuantity = new Dictionary<string, int>();
                        client.ProductAndQuantity[product] = quantity;
                        client.Price = price;
                        client.Bill = bill;
                        clients.Add(client);                      
                    }
                }
            }
            foreach (var client in clients.OrderBy(x => x.Name))
            {
                Console.WriteLine($"{client.Name}");
                foreach (var product in client.ProductAndQuantity)
                {
                    Console.WriteLine($"-- {product.Key} - {product.Value}");
                }               
                Console.WriteLine($"Bill: {client.Bill:f2}");
            }
            Console.WriteLine($"Total bill: {clients.Sum(x => x.Bill):f2}");
        }
    }
}
