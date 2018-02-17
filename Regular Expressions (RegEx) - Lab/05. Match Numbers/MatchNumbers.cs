using System;
using System.Linq;
using System.Text.RegularExpressions;

public class MatchNumbers
{
    public static void Main()
    {
        var pattern = @"(^|(?<=\s))-?\d+(.\d+)?($|(?=\s))";
        var numbers = Regex.Matches(Console.ReadLine(), pattern)
            .Cast<Match>()
            .Select(x => x.Value)
            .ToArray();
        Console.WriteLine(string.Join(" ", numbers));
    }
}