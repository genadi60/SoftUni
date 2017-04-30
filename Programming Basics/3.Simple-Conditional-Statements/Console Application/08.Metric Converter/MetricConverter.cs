using System;
using System.Collections.Generic;

class MetricConverter
{
    static void Main()
    {
        var sum = decimal.Parse(Console.ReadLine());
        var sourse = Console.ReadLine();
        var drain = Console.ReadLine();
        List<string> unit = new List<string>{ "m", "mm", "cm", "km", "in", "ft", "yd", "mi" };
        List<decimal> converter = new List<decimal>{ 1.00M, 1000.0M, 100.0M, 0.001M, 39.3700787M, 3.2808399M, 1.0936133M, 0.000621371192M };
        var s = unit.IndexOf(sourse);
        var d = unit.IndexOf(drain);
        var conv = sum * converter[d] / converter[s];

        Console.WriteLine("{0} {1}", conv, drain);
    }
}