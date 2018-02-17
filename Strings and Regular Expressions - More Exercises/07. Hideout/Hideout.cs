using System;
using System.Text.RegularExpressions;

public class Hideout
{
    public static void Main()
    {
        var line = Console.ReadLine();
        while (true)
        {
            var elements = Console.ReadLine().Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            var key = elements[0];
            var numberOfKeys = int.Parse(elements[1]);
            var pattern = @"(?<group>\" + key + @"{" +numberOfKeys +@",}).?";
            var regex = new Regex(pattern);
            var data = regex.Match(line);
            if (data.Success)
            {
                var index = data.Groups["group"].Index;
                var length = data.Groups["group"].Length;
                Console.WriteLine($"Hideout found at index {index} and it is with size {length}!");
                break;
            }
        }
        
    }
}