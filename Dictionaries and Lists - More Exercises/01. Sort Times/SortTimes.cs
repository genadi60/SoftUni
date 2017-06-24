using System;
using System.Linq;

public class SortTimes
{
    public static void Main()
    {
        var input = Console.ReadLine()
            .Split()
            .OrderBy(x => x)
            .ToList();
        Console.WriteLine(string.Join(", ", input));
    }
}