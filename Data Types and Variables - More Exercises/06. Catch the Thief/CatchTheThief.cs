using System;
using System.Collections.Generic;

public class CatchTheThief
{
    public static void Main()
    {
        var typeOfNumbers = Console.ReadLine();
        var n = int.Parse(Console.ReadLine());
        List<long> numbers = new List<long>();
        var maxNumber = long.MinValue;
        var result = 0L;
        var temp = 0L;
        for (int i = 0; i < n; i++)
        {
            if (long.TryParse(Console.ReadLine(), out temp))
            {
                numbers.Add(temp);
            }
             
        }
        switch (typeOfNumbers)
        {
            case "sbyte":
                foreach (var number in numbers)
                {
                    if (number <= sbyte.MaxValue && number >= sbyte.MinValue)
                    {
                        if (number > maxNumber)
                        {
                            maxNumber = number;
                            result = number;
                        }
                    }
                }
                
                break;
            case "int":
                foreach (var number in numbers)
                {
                    if (number <= int.MaxValue && number >= int.MinValue)
                    {
                        if (number > maxNumber)
                        {
                            maxNumber = number;
                            result = number;
                        }
                    }
                }
                
                break;
            case "long":
                foreach (var number in numbers)
                {
                    if (number <= long.MaxValue && number >= long.MinValue)
                    {
                        if (number > maxNumber)
                        {
                            maxNumber = number;
                            result = number;
                        }
                    }
                }
                
                break;
            default:
                break;
        }
        Console.WriteLine(result);
    }
}