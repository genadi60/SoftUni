using System;
using System.Linq;

public class ShortWordsSorted
{
    public static void Main()
    {
        var separators = new char[]
        {
            '.', ',', ':', ';', '(', ')', '[', ']',
            '\"', '\'', '\\', '/', '!', '?', ' '
        };
        var words = Console.ReadLine().ToLower()
            .Split(separators, StringSplitOptions.RemoveEmptyEntries)
            .Where(x => x.Length < 5)
            .ToList();
        words = words.Distinct().ToList();
        words.Sort();
        Console.WriteLine(string.Join(", ", words));
    }
}