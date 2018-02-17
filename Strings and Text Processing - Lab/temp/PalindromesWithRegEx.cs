using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class PalindromesWithRegEx
{
    public static void Main()
    {
        var pattern = @"\w+";
        List<string> words = new List<string>();
        var result = Regex.Matches(Console.ReadLine(), pattern);
        foreach (Match m in result)
        {
            words.Add(m.Value);
        }
        List<string> palindromes = new List<string>();
        foreach (var word in words)
        {
            var temp = String.Join("", word.Reverse().ToArray());
            if (temp.Equals(word))
            {
                palindromes.Add(word);
            }
        }
        palindromes = palindromes
            .Distinct()
            .OrderBy(x => x)
            .ToList();
        Console.WriteLine(string.Join(", ", palindromes));
    }
}