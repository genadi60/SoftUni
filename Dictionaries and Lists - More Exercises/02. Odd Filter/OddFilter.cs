using System;
using System.Collections.Generic;
using System.Linq;

public class OddFilter
{
    public static void Main()
    {
        var input = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();
        var filteredArea = input
            .Where(x => x % 2 == 0)
            .ToArray();
        var finalArea = filteredArea
            .Select(x => x > filteredArea.Average() ? ++x : --x)
            .ToArray();
        Console.WriteLine(string.Join(" ", finalArea));
    }
}