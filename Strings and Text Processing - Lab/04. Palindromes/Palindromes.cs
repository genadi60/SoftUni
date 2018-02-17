using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Palindromes
{
    public static void Main()
    {
        var delimiters = " ,.?!".ToCharArray();
        StringBuilder words = new StringBuilder();
        var line = Console.ReadLine().Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
        List<string> palindromes = new List<string>();
        for (int i = 0; i < line.Length; i++)
        {
            words.Append(line[i]);
            var temp = String.Join("", line[i].Reverse().ToArray());
            if (words.ToString().Contains(temp))
            {
                palindromes.Add(line[i]);
            }
        }
        palindromes = palindromes.Distinct().ToList();
        Console.WriteLine(string.Join(", ", palindromes.OrderBy(x => x)));
    }
}
