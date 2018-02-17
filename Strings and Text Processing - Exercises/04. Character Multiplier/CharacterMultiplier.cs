using System;
using System.Linq;

public class CharacterMultiplier
{
    public static void Main()
    {
        var line = Console.ReadLine();
        var arguments = line
            .Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
            .ToArray();
        var firstArg = arguments[0];
        var secondArg = arguments[1];
        if (firstArg.Length < secondArg.Length)
        {
            firstArg = arguments[1];
            secondArg = arguments[0];
        }
        var loop = Math.Max(firstArg.Length, secondArg.Length);
        var result = 0;
        var sum = 0;
        for (int i = 0; i < loop; i++)
        {
            if (i < secondArg.Length)
            {
                result = (int)firstArg[i] * (int)secondArg[i];
            }
            else
            {
                result = (int)firstArg[i];
            }
            sum += result;
        }
        Console.WriteLine(sum);
    }
}