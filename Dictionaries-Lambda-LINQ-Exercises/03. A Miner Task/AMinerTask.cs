using System;
using System.Collections.Generic;

public class AMinerTask
{
    public static void Main()
    {
        var dict = new Dictionary<string, long>();
        var command = Console.ReadLine();
        while (!command.Equals("stop"))
        {
            var value = long.Parse(Console.ReadLine());
            if (!dict.ContainsKey(command))
            {
                dict[command] = value;
            }
            else
            {
                dict[command] += value;
            }
            command = Console.ReadLine();
        }
        foreach (var kvp in dict)
        {
            Console.Write($"{kvp.Key} -> {kvp.Value}\n");
        }
    }
}