using System;
using System.Collections.Generic;

class CurrencyConverter
{
    static void Main()
    {
        var sum = decimal.Parse(Console.ReadLine());
        var sourse = Console.ReadLine();
        var drain = Console.ReadLine();
        List<string> currency = new List<string> {"BGN", "USD", "EUR", "GBP" };
        List<decimal> converterBG = new List<decimal> {1.00M, 1.79549M, 1.95583M, 2.53405M };
        var s = currency.IndexOf(sourse);
        var d = currency.IndexOf(drain);
        var conv = sum* converterBG[s] / converterBG[d];

        Console.WriteLine("{0:F2} {1}", conv, drain);
    }
}
