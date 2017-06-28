using System;
using System.Collections.Generic;
using System.Linq;


public class AndreyAndBilliard
{
    public class Customer
    {
        public string Name { get; set; }
        public Dictionary<string, int> Products { get; set; }
        public decimal Bill { get; set; }
    }
    public static void Main()
    {
        var products = new Dictionary<string, decimal>();
        var clientsAmonts = new SortedDictionary<string, Customer>();
        var n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            var productWithPrice = Console.ReadLine()
                .Split('-')
                .ToArray();
            var product = productWithPrice[0];
            var price = decimal.Parse(productWithPrice[1]);
            if (!products.ContainsKey(product))
            {
                products[product] = 0.00m;
            }
            products[product] = price;
        }
        var client = new Customer();
        while (true)
        {
            var clientsOrder = Console.ReadLine();
            if (clientsOrder.Equals("end of clients"))
            {
                break;
            }
            var clientOrder = clientsOrder
                .Split('-', ',')
                .ToArray();
            var name = clientOrder[0];
            var orderProduct = clientOrder[1];
            var quantity = int.Parse(clientOrder[2]);
            if (!products.ContainsKey(orderProduct))
            {
               continue;
            }
            var price = products[orderProduct];
            if (!clientsAmonts.ContainsKey(name))
            {
                client = new Customer();
                client.Name = name;
                client.Products = new Dictionary<string, int>();
                client.Products[orderProduct] = quantity;
                client.Bill = price * quantity;
                clientsAmonts[name] = client;
            }
            else
            {
                client = clientsAmonts[name];
                if (!client.Products.ContainsKey(orderProduct))
                {
                    client.Products[orderProduct] = 0;
                }
                client.Products[orderProduct] += quantity;
                client.Bill += price * quantity;
                
            }
        }
        var totalAmont = 0.00m;
        foreach (var kvp in clientsAmonts.OrderBy(x => client.Bill))
        {
            var name = kvp.Key;
            Console.WriteLine($"{name}");
            var order = kvp.Value;
            var amont = order.Bill;
            totalAmont += amont;
            foreach (var kvp2 in order.Products)
            {
                var product = kvp2.Key;
                var quantity = kvp2.Value;
                Console.WriteLine($"-- {product} - {quantity}");
            }
            Console.WriteLine($"Bill: {amont:F2}");
        }
        Console.WriteLine($"Total bill: {totalAmont:F2}");
    }
}