using System;
using System.Collections.Generic;
using System.Linq;

public class SumReversedNumbers
{
    public static void Main()
    {
        
        var userInput = Console.ReadLine()
            .Split(' ')
            .ToList();
        var sum = 0L;
        foreach (var element in userInput)
        {
            var curentElement = string.Empty;
            foreach (var digit in element)
            {
                curentElement = digit + curentElement;
            }
            sum += long.Parse(curentElement);
        }
        Console.WriteLine(sum);
    }
}