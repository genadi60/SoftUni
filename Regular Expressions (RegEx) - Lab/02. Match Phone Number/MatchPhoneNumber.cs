using System;
using System.Linq;
using System.Text.RegularExpressions;

public class MatchPhoneNumber
{
    public static void Main()
    {
        var line = Console.ReadLine();
        var pattern = @"\+[3][5][9]([ -])[2]\1[0-9]{3}\1[0-9]{4}\b";
        var telNumbers = Regex.Matches(line, pattern)
            .Cast<Match>()
            .Select(x => x.Value)
            .ToArray();
        Console.WriteLine(string.Join(", ", telNumbers));
    }
}