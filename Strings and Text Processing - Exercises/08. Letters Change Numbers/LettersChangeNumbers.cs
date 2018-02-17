using System;
using System.Linq;

public class LettersChangeNumbers
{
    public static void Main()
    {
        var line = Console.ReadLine();
        var numbersBetwinLetters = line
            .Split(" \t".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
            .ToArray();
        var sum = 0.0m;
        foreach (var numberBetwinLetters in numbersBetwinLetters)
        {
            var firstLetter = numberBetwinLetters.First();
            var secondLetter = numberBetwinLetters.Last();
            var stringNumber = numberBetwinLetters.Substring(1, numberBetwinLetters.Length - 2);
            var number = decimal.Parse(stringNumber);
            if (char.IsUpper(firstLetter))
            {
                var charposition = firstLetter - 'A' + 1;
                number /= charposition;
            }
            else
            {
                var charPosition = firstLetter - 'a' + 1;
                number *= charPosition;
            }
            if (char.IsUpper(secondLetter))
            {
                var charposition = secondLetter - 'A' + 1;
                number -= charposition;
            }
            else
            {
                var charPosition = secondLetter - 'a' + 1;
                number += charPosition;
            }
            sum += number;
        }
        Console.WriteLine("{0:F2}", sum);
    }
}