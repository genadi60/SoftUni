using System;
using System.Collections.Generic;

class SmallShop
{
    static void Main()
    {
        List<string> ware = new List<string> { "coffee", "water", "beer", "sweets", "peanuts" };
        decimal[] sofia = new decimal[] { 0.50m, 0.80m, 1.20m, 1.45m, 1.60m };
        decimal[] plovdiv = new decimal[] { 0.40m, 0.70m, 1.15m, 1.30m, 1.50m};
        decimal[] varna = new decimal[] { 0.45m, 0.70m, 1.10m, 1.35m, 1.55m};
        string inputWare = Console.ReadLine();
        string town = Console.ReadLine().ToLower();
        var qwantiti = decimal.Parse(Console.ReadLine());
        int i = ware.IndexOf(inputWare);
        switch (town)
        {
            case "sofia":
                Console.WriteLine((qwantiti * sofia[i]).ToString().TrimEnd('0').TrimEnd('.'));
                break;
            case "plovdiv":
                Console.WriteLine((qwantiti * plovdiv[i]).ToString().TrimEnd('0').TrimEnd('.'));
                break;
            case "varna":
                Console.WriteLine((qwantiti * varna[i]).ToString().TrimEnd('0').TrimEnd('.'));
                break;
            default:
                break;
        }
     }
}