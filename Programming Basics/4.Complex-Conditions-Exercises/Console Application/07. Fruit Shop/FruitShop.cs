using System;
using System.Collections.Generic;

class FruitShop
{
    static void Main()
    {
        List<string> fruit = new List<string> { "banana", "apple", "orange", "grapefruit", "kiwi", "pineapple", "grapes" };
        List<string> days = new List<string> { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        List<decimal> preis1 = new List<decimal> { 2.50m, 1.20m, 0.85m, 1.45m, 2.70m, 5.50m, 3.85m };
        List<decimal> preisWeekend = new List<decimal> { 2.70m, 1.25m, 0.90m, 1.60m, 3.00m, 5.60m, 4.20m };
        int indexFruit = fruit.IndexOf(Console.ReadLine());
        int indexDays = days.IndexOf(Console.ReadLine());
        var qwantiti = decimal.Parse(Console.ReadLine());
        if (indexFruit < 0 || indexDays < 0)
        {
            Console.WriteLine("error");
        }
        else
        {
            if (indexDays < 5)
            {
                Console.WriteLine("{0:F2}",preis1[indexFruit] * qwantiti);
            }
            else
            {
                Console.WriteLine("{0:F2}",preisWeekend[indexFruit] * qwantiti);
            }
        }
    }
}