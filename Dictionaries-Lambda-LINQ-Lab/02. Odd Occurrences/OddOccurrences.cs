using System;
using System.Collections.Generic;
using System.Linq;

public class OddOccurrences
{
    public static void Main()
    {
        var dict = new Dictionary<string, int>();
        var words = Console.ReadLine()
            .ToLower()
            .Split()
            .ToArray();
        foreach (var word in words)
        {
            if (!dict.ContainsKey(word))
            {
                dict[word] = 1;
            }
            else
            {
                dict[word]++;
            }
        }
        var output = new List<string>();
        foreach (var kvp in dict)
        {
            if (kvp.Value % 2 != 0)
            {
               output.Add(kvp.Key); 
            }
        }
        Console.WriteLine(string.Join(", ", output));
    }
}