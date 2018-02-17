using System;
using System.Linq;
using System.Text.RegularExpressions;

public class ExtractEmails
{
    public static void Main()
    {
        var pattern = @"(?<=\s)[a-z0-9]+([._-][a-z0-9]+)*@[a-z]+([-.][a-z]+)*\.[a-z]{2,}";
        var valideMails = Regex.Matches(Console.ReadLine(), pattern)
            .Cast<Match>()
            .Select(x => x.Value)
            .Distinct()
            .ToArray();
        foreach (var mail in valideMails)
        {
            Console.WriteLine(string.Join("", mail));
        }
    }
}