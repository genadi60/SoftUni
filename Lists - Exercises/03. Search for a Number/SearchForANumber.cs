using System;
using System.Linq;

public class SearchForANumber
{
    public static void Main()
    {
        var numbers = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToList();
        var manipul = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();
        var result = string.Empty;
        numbers = numbers
            .Take(manipul[0])
            .Skip(manipul[1])
            .ToList();
        if (numbers.Contains(manipul[2]))
        {
            result = "YES!";
        }
        else
        {
            result = "NO!";
        }
        Console.WriteLine(result);
    }
}