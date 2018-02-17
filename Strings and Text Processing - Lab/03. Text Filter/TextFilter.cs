using System;
using System.Linq;
using System.Text.RegularExpressions;

public class TextFilter
{
    public static void Main()
    {
        var patterns = Console.ReadLine().Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToArray();
        var text = Console.ReadLine();
        for (int i = 0; i < patterns.Length; i++)
        {
            var pattern = $@"{patterns[i]}";
            text = Regex.Replace(text, pattern, x =>"" + new string('*', x.Length));
        }
        Console.WriteLine(text);
    }
}