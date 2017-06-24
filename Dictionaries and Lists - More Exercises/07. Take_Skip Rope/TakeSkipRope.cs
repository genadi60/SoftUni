using System;
using System.Collections.Generic;
using System.Linq;

public class TakeSkipRope
{
    public static void Main()
    {
        var input = Console.ReadLine();
        var numbers = new List<char>();
        var nonNumbers = new List<char>();
        foreach (var sign in input)
        {
            if (char.IsDigit(sign))
            {
                numbers.Add(sign);
            }
            else
            {
                nonNumbers.Add(sign);
            }
        }
        var text = string.Join("", nonNumbers);
        var takeList = new List<int>();
        var skipList = new List<int>();
        var total = new List<int>();
        for (int i = 0; i < numbers.Count; i++)
        {
            if (i % 2 == 0)
            {
                takeList.Add(numbers[i] - '0');
            }
            else
            {
                skipList.Add(numbers[i] - '0');
                total.Add((numbers[i] - '0') + (numbers[i - 1] - '0'));
            }
        }
        total.Insert(0,0);
        var result = string.Empty;
        var skippedNumber = 0;
        for (int i = 0; i < skipList.Count; i++)
        {
            skippedNumber += total[i];
            var temp = text
                .Skip(skippedNumber)
                .Take(takeList[i])
                .ToArray();
            result += (string.Join("",temp));
        }
        Console.WriteLine(result);
    }
}