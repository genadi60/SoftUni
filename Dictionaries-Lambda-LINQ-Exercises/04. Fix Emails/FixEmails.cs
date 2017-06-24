using System;
using System.Collections.Generic;

public class FixEmails
{
    public static void Main()
    {
        var dict = new Dictionary<string, string>();
        var command = Console.ReadLine();
        while (!command.Equals("stop"))
        {
            var value = Console.ReadLine();
            if (!(value.EndsWith("us") || value.EndsWith("uk")))
            {
                dict[command] = value;
            }
            command = Console.ReadLine();
        }
        foreach (var kvp in dict)
        {
            Console.Write($"{kvp.Key} -> {kvp.Value}\n");
        }
    }
}