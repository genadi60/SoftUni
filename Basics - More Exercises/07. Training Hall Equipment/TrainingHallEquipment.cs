using System;

public class TrainingHallEquipment
{
    public static void Main()
    {
        var budget = decimal.Parse(Console.ReadLine());
        var itemsNumber = int.Parse(Console.ReadLine());
        var subTotal = 0m;
        for (int i = 0; i < itemsNumber; i++)
        {
            var item = Console.ReadLine();
            var itemPrice = decimal.Parse(Console.ReadLine());
            var itemCount = int.Parse(Console.ReadLine());
            if (itemCount > 1)
            {
                if (item.EndsWith("y"))
                {
                    item = item.Remove(item.Length - 1);
                    item += "ies";
                }
                else if (item.EndsWith("o") || item.EndsWith("x") ||
                        item.EndsWith("s") ||
                        item.EndsWith("z") ||
                        item.EndsWith("ch") ||
                        item.EndsWith("sh"))
                {
                    item += "es";
                }
                else
                {
                    item += "s";
                }
            }
            subTotal += itemPrice * itemCount;
            Console.WriteLine($"Adding {itemCount} {item} to cart.");
        }

        Console.WriteLine($"Subtotal: ${subTotal:F2}");

        if (budget > subTotal)
        {
            Console.WriteLine($"Money left: ${(budget - subTotal):F2}");
        }
        else
        {
            Console.WriteLine($"Not enough. We need ${(subTotal - budget):F2} more.");
        }
    }
}