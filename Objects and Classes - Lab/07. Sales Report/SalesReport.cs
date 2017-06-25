using System;
using System.Collections.Generic;
using System.Linq;

public class SalesReport
{
    class Sales
    {
        public string Town { get; set; }
        public string Product { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }
        public override string ToString()
        {
            return Town + " -> " + Product + ": " + Quantity;
        }
    }
    public static void Main()
    {
        var salesNumber = int.Parse(Console.ReadLine());
        var totalSalesByTown = new Dictionary<string, decimal>();
        var salesByTownPricesQuantity = new List<Sales>();
        var sales = new Sales();
        for (int i = 0; i < salesNumber; i++)
        {
            sales = ReadSale(Console.ReadLine());
            salesByTownPricesQuantity.Add(sales);
        }
        var town = string.Empty;
        var product = string.Empty;
        var price = 0.00m;
        var quantity = 0.00m;
        for(int i = 0; i < salesByTownPricesQuantity.Count; i++)
        {
            town = salesByTownPricesQuantity[i].Town;
            
            price = salesByTownPricesQuantity[i].Price;
            quantity = salesByTownPricesQuantity[i].Quantity;
            var totalPrice = price * quantity;
            if (!totalSalesByTown.ContainsKey(town))
            {
                totalSalesByTown[town] = 0.00m;
            }
            totalSalesByTown[town] += totalPrice;
        }
        foreach (var kvp in totalSalesByTown.OrderBy(x => x.Key))
        {
            var city = kvp.Key;
            var proceeds = kvp.Value;
            Console.WriteLine($"{city} -> {proceeds:F2}");
        }
    }

    static Sales ReadSale(string input)
    {
        var s = new Sales();
        var salesByTown = input
            .Split()
            .ToArray();
        s.Town = salesByTown[0];
        s.Product = salesByTown[1];
        s.Price = decimal.Parse(salesByTown[2]);
        s.Quantity = decimal.Parse(salesByTown[3]);
        return s;
    }
}