using System;
using System.Linq;

public class Largest3Numbers
{
    public static void Main()
    {
        var numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .OrderByDescending(x => x)
            .ToList();
        var output = numbers.Take(3);
        Console.WriteLine(string.Join(" ", output));
    }
}