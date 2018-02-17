using System;
using System.Linq;

public class ReverseString
{
    public static void Main()
    {
        var line = Console.ReadLine();
        var output = line
            .Reverse()
            .ToArray();
        Console.WriteLine(String.Join("", output));
    }
}