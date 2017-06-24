using System;
using System.Collections.Generic;
using System.Linq;

public class PhonebookUpgrade
{
    public static void Main()
    {
        var commands = Console.ReadLine()
            .Split()
            .ToList();
        var phonebook = new SortedDictionary<string, string>();
        var command = commands[0];
        var key = string.Empty;
        while (!command.Equals("END"))
        {
            if (commands.Count > 1)
            {
                key = commands[1];
            }
            if (command.Equals("A"))
            {
                var value = commands[2];
                phonebook[key] = value;
            }
            else if(command.Equals("S"))
            {
                if (!phonebook.ContainsKey(key))
                {
                    Console.WriteLine($"Contact {key} does not exist.");
                }
                else
                {
                    Console.WriteLine($"{key} -> {phonebook[key]}");
                }
            }
            else if (command.Equals("ListAll"))
            {
                foreach (var kvp in phonebook)
                {
                    Console.Write($"{kvp.Key} -> {kvp.Value}\n");
                }
                
            }
            commands = Console.ReadLine()
                .Split()
                .ToList();
            command = commands[0];
        }
    }
}