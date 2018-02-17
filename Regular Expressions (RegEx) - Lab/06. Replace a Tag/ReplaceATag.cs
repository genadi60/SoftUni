using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class ReplaceATag
{
    public static void Main()
    {
        List<string> tags = new List<string>();
        var pattern = @"<a.*?href.*?=(.*?)>(.*?)<\/a>";
        var replacement = @"[URL href=$1]$2[/URL]";
        while (true)
        {
            var line = Console.ReadLine();
            if (line == "end")
            {
                break;
            }
            var rep = Regex.Replace(line, pattern, replacement);
            tags.Add(rep);
        }
        foreach (var tag in tags)
        {
            Console.WriteLine(tag);
        }
    }
}