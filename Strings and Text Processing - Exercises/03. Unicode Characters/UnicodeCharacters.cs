using System;

public class UnicodeCharacters
{
    public static void Main()
    {
        var line = Console.ReadLine();
        foreach (var character in line)
        {
            var unicode = "\\u" + ((int)character).ToString("x4");
            Console.Write(unicode);
        }
        Console.WriteLine();
    }
}