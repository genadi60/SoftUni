using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

public class Mines
{
    public static void Main()
    {
        var pattern = @"(?<bomb><(?<power>.{2})>)";
        var regex = new Regex(pattern);
        var line = Console.ReadLine();
        StringBuilder output = new StringBuilder();
        output.Append(line);
        MatchCollection bombs = regex.Matches(line);
        var power = 0;
        var index = 0;
        var size = 0;
        foreach (Match bomb in bombs)
        {
            var bombElements = bomb.Groups["power"].Value.ToCharArray();
            size = bomb.Groups["bomb"].Length;
            power = Math.Abs((int) bombElements[0] - (int) bombElements[1]);
            index = bomb.Groups["bomb"].Index;
            var replacement = new StringBuilder();
            output.Remove(index, size);
            for (int i = 0; i < size; i++)
            {
                replacement.Append("_");
            }
            output.Insert(index, replacement);
            replacement.Clear();
            if ((index - power) < 0)
            {
                output.Remove(0, index);
                for (int i = 0; i < index; i++)
                {
                    replacement.Append("_");
                }
                output.Insert(0, replacement);
                replacement.Clear();
            }
            else
            {
                output.Remove(index - power, power);
                for (int i = 0; i < power; i++)
                {
                    replacement.Append("_");
                }
                output.Insert(index - power, replacement);
                replacement.Clear();
            }
            if ((index + size + power) > (output.Length - 1))
            {
                for (int i = 0; i < output.Length - index - size; i++)
                {
                    replacement.Append("_");
                }
                output.Remove(index + size, output.Length - index - size);
                output.Append(replacement);
                replacement.Clear();
            }
            else
            {
                for (int i = 0; i < power; i++)
                {
                    replacement.Append("_");
                }
                output.Remove(index + size, power);
                output.Insert(index + size, replacement);
                replacement.Clear();
            }
        }
        Console.WriteLine(output);
    }
}