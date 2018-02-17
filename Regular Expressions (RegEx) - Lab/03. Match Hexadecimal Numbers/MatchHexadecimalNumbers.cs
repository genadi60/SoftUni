using System;
using System.Linq;
using System.Text.RegularExpressions;

public class MatchHexadecimalNumbers
{
    public static void Main()
    {
        var pattern = @"\b(?:0x)?[0-9A-F]+\b";
        var numbers = Regex.Matches(Console.ReadLine(), pattern)
            .Cast<Match>()
            .Select(x => x.Value)
            .ToArray();
        Console.WriteLine(string.Join(" ", numbers));
    }
}