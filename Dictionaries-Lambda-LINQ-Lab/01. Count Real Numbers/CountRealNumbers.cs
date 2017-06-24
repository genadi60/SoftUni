using System;
using System.Collections.Generic;
using System.Linq;

public class CountRealNumbers
{
    public static void Main()
    {
        var realNumbers = new SortedDictionary<double, int>();
        var numbers = Console.ReadLine()
            .Split()
            .Select(double.Parse)
            .ToArray();
        foreach (var number in numbers)
        {
            if (!realNumbers.ContainsKey(number))
            {
                realNumbers[number] = 1;
            }
            else
            {
                realNumbers[number]++;
            }
        }
        foreach (var kvp in realNumbers)
        {
            Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
        }
    }
}