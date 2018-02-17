using System;
using System.IO;
using System.Linq;

public class PunctuationFinder
{
    public static void Main()
    {
        var text = File.ReadAllText("sample_text.txt");
        var newText = text
            .Where(x => !(x.Equals('.') || x.Equals(',') || x.Equals(':') || x.Equals('!') || x.Equals('?')))
            .ToArray();
        var sampleText = String.Join("", newText);
        File.WriteAllText("withOutPunctuationChars.txt", sampleText);
    }
}