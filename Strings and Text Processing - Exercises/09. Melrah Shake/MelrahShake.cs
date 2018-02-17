using System;
using System.Linq;

public class MelrahShake
{
    public static void Main()
    {
        var word = Console.ReadLine();
        var pattern = Console.ReadLine();
        while (pattern.Length > 0)
        {
            var start = word.IndexOf(pattern);
            var end = word.LastIndexOf(pattern);
            if (start >= 0 && end > start)
            {
                word = word.Remove(end, pattern.Length);
                word = word.Remove(start, pattern.Length);
                Console.WriteLine("Shaked it.");
                pattern = pattern.Remove(pattern.Length / 2, 1);
            }
            else
            {
                break;
            }
        }
        Console.WriteLine("No shake.");
        Console.WriteLine(word);
    }
}