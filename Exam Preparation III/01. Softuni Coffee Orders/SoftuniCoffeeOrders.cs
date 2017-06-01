using System;
using System.Globalization;

class SoftuniCoffeeOrders
{
    static void Main()
    {
        var ordersNumber = int.Parse(Console.ReadLine());
        decimal sum = 0m;
        while (ordersNumber > 0)
        {
            var pricePerCapsule = decimal.Parse(Console.ReadLine());
            var orderDate = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
            var capsulesCountPerDay = long.Parse(Console.ReadLine());
            var daysOfMonth = DateTime.DaysInMonth(orderDate.Year, orderDate.Month);
            var price = daysOfMonth * capsulesCountPerDay * pricePerCapsule;
            sum += price;
            Console.WriteLine($"The price for the coffee is: ${price:F2}");
            ordersNumber--;
        }
        Console.WriteLine($"Total: ${sum:F2}");
    }
}