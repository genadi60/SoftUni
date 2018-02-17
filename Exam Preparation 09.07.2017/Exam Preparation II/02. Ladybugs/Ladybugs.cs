using System;
using System.Collections.Generic;
using System.Linq;

public class Ladybugs
{
    public static void Main()
    {
        var bugs = new Dictionary<long, byte>();
        var fieldSize = int.Parse(Console.ReadLine());
        //byte[] field = new byte[fieldSize];
        var ladybugsIndexes = Console.ReadLine()
            .Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
            .Select(x => x.Trim())
            .Where(x => !x.Equals(""))
            .Select(int.Parse)
            .Where(x => x >= 0 && x < fieldSize)
            .ToArray();
        for (int i = 0; i < fieldSize; i++)
        {
            if (ladybugsIndexes.Contains(i))
            {
                bugs[i] = 1;
            }
            else
            {
                bugs[i] = 0;
            }
        }
        while (true)
        {
            var command = Console.ReadLine();
            if (command == "end")
            {
                break;
            }
            var commandData = command
                .Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim())
                .ToArray();
            if (commandData.Length == 3)
            {
                var index = long.Parse(commandData[0]);
                if (index < 0 || index >= fieldSize)
                {
                    continue;
                }
                var direction = commandData[1];
                var flyLength = long.Parse(commandData[2]);
                var dir = -1;
                if (direction.Equals("right"))
                {
                    dir = 1;
                }
                if (bugs.ContainsKey(index))
                {
                    if (bugs[index] == 1)
                    {
                        bugs[index] = 0;
                        index += flyLength * dir;
                    }
                    else
                    {
                        continue;
                    }
                }
                else
                {
                    continue;
                }
                while (bugs.ContainsKey(index))
                {
                    
                    if (bugs[index] == 0)
                    {
                        bugs[index] = 1;
                        break;
                    }
                    else
                    {
                        index += flyLength * dir;
                    }
                }
            }
            else
            {
                continue;
            }
        }
        var field = new List<byte>();
        for (int i = 0; i < fieldSize; i++)
        {
            field.Add(bugs[i]);
        }
        var stringOut = String.Join(" ", field);
        Console.WriteLine(stringOut);
    }
}