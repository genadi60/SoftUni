using System;
using System.Text.RegularExpressions;

public class OnlyLetters
{
    public static void Main()
    {
        var line = Console.ReadLine();

        var pattern = @"\b.*?((?<number>[0-9]{1,})(?<leter>[a-zA-Z]{1}))";
        var groupsElement = Regex.Match(line, pattern);
        while (groupsElement.Success)
        {
            var replacePattern = groupsElement.Groups["number"].ToString();
            var replacement = groupsElement.Groups["leter"].Value;
            line = Regex.Replace(line, replacePattern, replacement);
            pattern = @"\b.*?((?<number>[0-9]{1,})(?<leter>[a-zA-Z]{1}))";
            groupsElement = Regex.Match(line, pattern);
        }
        Console.WriteLine(line);
    }
}