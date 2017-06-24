using System;
using System.Linq;

public class BombNumbers
{
    public static void Main()
    {
        var seqOfNumbers = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToList();
        var bombAction = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();
        var bombNumber = bombAction[0];
        var bombSize = bombAction[1];
        while (seqOfNumbers.Contains(bombNumber))
        {
            var index = seqOfNumbers.IndexOf(bombNumber);
            var lengthOfBomb = 0;
            var startIndex = 0;
            if ((index + bombSize) >= seqOfNumbers.Count)
            {
                lengthOfBomb = seqOfNumbers.Count - (index - bombSize);
            }
            else
            {
                lengthOfBomb = (bombSize * 2 + 1);
            }
            if ((index - bombSize) >= 0)
            {
                startIndex = (index - bombSize);
            }
            else
            {
                lengthOfBomb = lengthOfBomb - (bombSize - index);
            }
            seqOfNumbers.RemoveRange(startIndex, lengthOfBomb);
        }
        var sumOfNumbers = seqOfNumbers.Sum();
        Console.WriteLine(sumOfNumbers);
    }
}