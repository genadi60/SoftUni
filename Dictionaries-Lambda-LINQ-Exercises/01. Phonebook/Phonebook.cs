using System;
using System.Collections.Generic;
using System.Linq;

public class Phonebook
{
    public static void Main()
    {
        var commands = Console.ReadLine()
            .Split()
            .ToList();
        var phonebook = new Dictionary<string, string>();
        var command = commands[0];
        while (!command.Equals("END"))
        {
            var key = commands[1];
            
            if (command.Equals("A"))
            {
                var value = commands[2];
                phonebook[key] = value;
            }
            else
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
            commands = Console.ReadLine()
                .Split()
                .ToList();
            command = commands[0];
        }
    }
}