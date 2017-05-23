using System;
using System.Collections.Generic;
using System.Linq;

class MaxMethod
{
    static void Main()
    {
        List<double> numbers = new List<double> { };
        var n = 3;
        for (int i = 0; i < n; i++)
        {
            var number = double.Parse(Console.ReadLine());
            numbers.Add(number);
        }
        PrintMinNumber(numbers);
    }

    static void PrintMinNumber(List<double> numbers)
    {
        Console.WriteLine(numbers.Max());
    }
}