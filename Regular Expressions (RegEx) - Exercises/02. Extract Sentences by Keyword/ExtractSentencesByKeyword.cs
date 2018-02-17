using System;
using System.Linq;
using System.Text.RegularExpressions;

public class ExtractSentencesByKeyword
{
    public static void Main()
    {
        var keyword = Console.ReadLine();
        var inputSentences = Console.ReadLine()
            .Split(".?!".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
            .ToArray();
        var pattern = @"\W" + keyword + @"\W";
        foreach (var sentence in inputSentences)
        {
            if (Regex.IsMatch(sentence, pattern))
            {
                Console.WriteLine(sentence.TrimStart());
            }
        }
    }
}