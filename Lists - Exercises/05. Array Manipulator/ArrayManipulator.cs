using System;
using System.Collections.Generic;
using System.Linq;

public class ArrayManipulator
{
    public static void Main()
    {
        var inputNumbers = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToList();
        GetManipulatingArray(inputNumbers);
        Console.WriteLine($"[{string.Join(", ", inputNumbers)}]");
    }

    public static void GetManipulatingArray(List<int> numbers)
    {
        var commands = Console.ReadLine()
            .Split(' ')
            .ToArray();

        while (!commands[0].Equals("print"))
        {
            switch (commands[0])
            {
                case "add":
                    numbers.Insert(int.Parse(commands[1]), int.Parse(commands[2]));
                    break;
                case "addMany":
                    int[] range = new int[commands.Length - 2];
                    for (var i = 2; i < commands.Length; i++)
                    {
                        range[i - 2] = int.Parse(commands[i]);
                    }
                    numbers.InsertRange(int.Parse(commands[1]), range);
                    break;
                case "contains":
                    Console.WriteLine(numbers.IndexOf(int.Parse(commands[1])));
                    break;
                case "remove":
                    numbers.RemoveAt(int.Parse(commands[1]));
                    break;
                case "shift":
                    var shiftNumber = long.Parse(commands[1]);
                    var shift = (int)(shiftNumber % numbers.Count);
                    for (var i = 0; i < shift; i++)
                    {
                        numbers.Add(numbers[0]);
                        numbers.RemoveAt(0);
                    }
                    break;
                case "sumPairs":
                    List<int> sumPairs = new List<int>();
                    for (var i = 0; i < numbers.Count; i += 2)
                    {
                        if (i < numbers.Count -1)
                        {
                            var sum = numbers[i] + numbers[i + 1];
                            sumPairs.Add(sum);
                        }
                        else
                        {
                            sumPairs.Add(numbers[numbers.Count - 1]);
                        }
                    }
                    numbers.Clear();
                    numbers.AddRange(sumPairs);
                    break;
            }
            
            commands = Console.ReadLine()
                .Split(' ')
                .ToArray();
        }
    }
}