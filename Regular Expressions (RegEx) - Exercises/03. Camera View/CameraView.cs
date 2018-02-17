using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class CameraView
{
    public static void Main()
    {
        var actions = Console.ReadLine()
            .Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();
        var skiper = actions[0];
        var taker = actions[1];
        var pattern = @"\|<(\w{" + skiper + @"})(\w{0," + taker +@"})";
        var words = Regex.Matches(Console.ReadLine(), pattern)
            .Cast<Match>()
            .Select(x => x.Groups[2].Value)
            .ToArray();
        Console.WriteLine(string.Join(", ", words));
    }
}