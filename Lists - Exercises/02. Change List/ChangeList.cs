using System;
using System.Collections.Generic;
using System.Linq;

public class ChangeList
{
    public static void Main()
    {
        var numbers = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToList();
        var commands = Console.ReadLine()
            .Split(' ')
            .ToArray();
        var result = new List<int>();
        var command = commands[0];
        while (!command.Equals("Odd") && !command.Equals("Even"))
        {
            switch (command)
            {
                case "Delete":
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] == int.Parse(commands[1]))
                        {
                            numbers.Remove(numbers[i]);
                            i--;
                        }
                    }
                    
                    break;
                case "Insert":
                    numbers
                        .Insert(int.Parse(commands[2]), int.Parse(commands[1]));
                    break;
            }
            commands = Console.ReadLine()
                .Split(' ')
                .ToArray();
            command = commands[0];
        }
        if (command.Equals("Odd"))
        {
           result = numbers
                .Where(x => x % 2 != 0)
                .ToList();
        }
        else
        {
           result = numbers
                .Where(x => x % 2 == 0)
                .ToList();
        }
        Console.WriteLine(string.Join(" ", result));
    }
}