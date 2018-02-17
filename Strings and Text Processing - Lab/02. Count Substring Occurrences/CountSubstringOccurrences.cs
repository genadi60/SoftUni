using System;

public class CountSubstringOccurrences
{
    public static void Main()
    {
        var line = Console.ReadLine().ToLower();
        var code = Console.ReadLine().ToLower();
        var count = 0;
        if (line.Equals(String.Empty) || code.Equals(String.Empty))
        {
            Console.WriteLine(count);
            return;
        }
        var testString = line.Split(" \t".ToCharArray(),StringSplitOptions.RemoveEmptyEntries);
        var wordCopy = String.Join("",testString); 
        while (wordCopy.Contains(code) && wordCopy.Length >= code.Length)
        {
            var s = wordCopy.IndexOf(code);
            count++;
            wordCopy = wordCopy.Substring(s + 1);
        }
        Console.WriteLine(count);
    }
}