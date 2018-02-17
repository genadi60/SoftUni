using System;
using System.Text.RegularExpressions;

public class Regexmon
{
    public static void Main()
    {
        var didimonPattern = @"[\?\!\^\,\.\/\\\$\@\s\#\%\&\*\(\)\+\=\~\`_\<\>\|""\'\]\[\{\}0-9]+";
        var bojomonPattern = @"[a-zA-Z]+[-][a-zA-Z]+";
        var input = Console.ReadLine();
        var didimonRegex = new Regex(didimonPattern);
        var bojomonRegex = new Regex(bojomonPattern);
        while (input.Length > 0)
        {
            var didiMatch = didimonRegex.Match(input);
            if (didiMatch.Success)
            {
                var output = String.Join("", didiMatch.Value);
                Console.WriteLine(output);
                input = input.Substring(didiMatch.Index + output.Length);
            }
            else
            {
                Console.WriteLine("");
                break;
            }
            if (input.Length > 0)
            {
                var bojoMatch = bojomonRegex.Match(input);
                if (bojoMatch.Success)
                {
                    var output = String.Join("", bojoMatch.Value);
                    Console.WriteLine(output);
                    input = input.Substring(bojoMatch.Index + output.Length);
                }
                else
                {
                    Console.WriteLine("");
                    break;
                }
            }
            else
            {
                Console.WriteLine("");
                break;
            }
        }
    }
}