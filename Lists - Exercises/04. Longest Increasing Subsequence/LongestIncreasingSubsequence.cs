using System;
using System.Collections.Generic;
using System.Linq;

public class MaxSequenceOfEqualElements
{
    public static void Main()
    {
        var numbers = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToList();
        List<int> longestSequence = FindLongestSequence(numbers);
        
        Console.WriteLine(string.Join(" ", longestSequence));
    }

    public static List<int> FindLongestSequence(List<int> numbers)
    {
        var len = new int[numbers.Count];
        len[0] = 1;
        var prev = new int[numbers.Count];
        prev[0] = -1;
        for (int i = 1; i < numbers.Count; i++)
        {
            var count = 0;
            int[] maxLen = new int[numbers.Count];
            for (int j = i - 1; j >= 0; j--)
            {
                if (numbers[i] > numbers[j])
                {
                    maxLen[j] = len[j] + 1;
                    count++;
                }
            }
            if (count > 0)
            {
                prev[i] = Array.IndexOf(maxLen, maxLen.Max());
                len[i] = maxLen[prev[i]];
            }
            else
            {
                prev[i] = -1;
                len[i] = 1;
            }
        }
        var maxLength = len.Max();
        var indexMaxLength = Array.IndexOf(len, maxLength);
        var result = new List<int>();
        while (maxLength > 0)
        {
            result.Add(numbers[indexMaxLength]);
            indexMaxLength = prev[indexMaxLength];
            maxLength--;
        }
        result.Reverse();
        return result;
    }
}