using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
public class MatchFullName
{
    public static void Main()
    {
        var pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+";
        List<string> names = new List<string>();
        MatchCollection matches = Regex.Matches(Console.ReadLine(), pattern);
        foreach (Match mathc in matches)
        {
            names.Add(mathc.Groups[0].Value);
        }
        Console.WriteLine(String.Join(" ", names));
    }
}