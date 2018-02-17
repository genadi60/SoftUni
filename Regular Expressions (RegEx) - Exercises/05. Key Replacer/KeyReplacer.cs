using System;
using System.Text;
using System.Text.RegularExpressions;

public class KeyReplacer
{
    
    public static void Main()
    {
        var pattern = @"(?<start>[a-zA-Z]+)[\|\<\\].*?[\|\<\\](?<end>[a-zA-Z]+)";
        Regex regex = new Regex(pattern);
        var keyCombination = regex.Match(Console.ReadLine());
        var startKey = string.Empty;
        var endKey = string.Empty;
        StringBuilder output = new StringBuilder();
        if (keyCombination.Success)
        {
            startKey = keyCombination.Groups["start"].Value;
            endKey = keyCombination.Groups["end"].Value;
            var patternNew = startKey + @"(?<message>.*?)" + endKey;
            regex = new Regex(patternNew);
            MatchCollection phrases = regex.Matches(Console.ReadLine());
            foreach (Match message in phrases)
            {
                if (message.Success)
                {
                    output.Append(message.Groups["message"].Value);
                }
            }
        }
        if (output.Length > 0)
        {
            Console.WriteLine(output);
        }
        else
        {
            Console.WriteLine("Empty result");
        }
        
    }
}