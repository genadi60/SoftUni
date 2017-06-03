using System;
using System.Collections.Generic;

public class SentenceTheThief
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
        long sentence = 0L;
        if (result < 0)
        {
            sentence = (long)Math.Ceiling(result / -128.0);
        }
        else
        {
            sentence = (long)Math.Ceiling(result / 127.0);
        }
        if (sentence > 1)
        {
            Console.WriteLine($"Prisoner with id {result} is sentenced to {sentence} years");
        }
        else
        {
            Console.WriteLine($"Prisoner with id {result} is sentenced to {sentence} year");
        }
    }
}