using System;
using System.Text.RegularExpressions;

public class Censorship
{
    public static void Main()
    {
        var word = Console.ReadLine();
        var replacement = new string('*', word.Length);
        Regex regex = new Regex(word);
        var sentence = Console.ReadLine();
        var censoredSentence = regex.Replace(sentence, replacement);
        Console.WriteLine(censoredSentence);
    }
}