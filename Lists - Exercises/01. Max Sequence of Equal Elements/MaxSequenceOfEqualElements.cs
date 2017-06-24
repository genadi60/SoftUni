using System;
using System.Linq;


public class MaxSequenceOfEqualElements
{
    public static void Main()
    {
        var numbers = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToList();
        var count = 1;
        var maxLength = 1;
        var index = 0;
        for (int i = 1; i < numbers.Count; i++)
        {
            if (numbers[i - 1] == numbers[i])
            {
                count++;
                if (count > maxLength)
                {
                    maxLength = count;
                    index = i;
                }
            }
            else
            {
                count = 1;
            }
        }
        var maxSequence = numbers
            .GetRange(index - maxLength + 1, maxLength)
            .ToList();
        Console.WriteLine(string.Join(" ", maxSequence));
    }
}