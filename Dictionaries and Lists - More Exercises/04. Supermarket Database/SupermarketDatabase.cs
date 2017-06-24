using System;
using System.Collections.Generic;
using System.Linq;

public class SupermarketDatabase
{
    public static void Main()
    {
        var productsQuantity = new Dictionary<string, int>();
        var productPrice = new Dictionary<string, decimal>();
        while (true)
        {
            var input = Console.ReadLine();
            if (input.Equals("stocked"))
            {
                break;
            }
            var product = input
                .Split()
                .ToArray();
            var productName = product[0];
            var price = decimal.Parse(product[1]);
            var quantity = int.Parse(product[2]);
            if (!productsQuantity.ContainsKey(productName))
            {
                productsQuantity[productName] = 0;
            }
            productsQuantity[productName] += quantity;
            if (!productPrice.ContainsKey(productName))
            {
                productPrice[productName] = 0.00m;
            }
            productPrice[productName] = price;
        }
        var grandTotal = 0.00m;
        foreach (var kvp in productsQuantity)
        {
            var name = kvp.Key;
            var quantity = kvp.Value;
            var unitPrice = productPrice[name];
            var price = quantity * unitPrice;
            grandTotal += price;
            Console.WriteLine($"{name}: ${unitPrice:F2} * {quantity} = ${price:F2}");
        }
        Console.WriteLine(new String('-', 30));
        Console.WriteLine($"Grand Total: ${grandTotal:F2}");
    }
}