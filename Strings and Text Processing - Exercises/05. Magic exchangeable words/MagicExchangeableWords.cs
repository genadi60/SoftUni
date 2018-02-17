using System;
using System.Collections.Generic;
using System.Linq;

public class MagicExchangeableWords
{
    public static void Main()
    {
        
        var line = Console.ReadLine().ToLower();
        var inputWords = line
            .Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
            .ToArray();
        var firstWord = inputWords[0];
        var secondWord = inputWords[1];
        var output = ExchangeableWords(firstWord, secondWord);
        Console.WriteLine(output.ToString().ToLower());
    }

    static bool ExchangeableWords(string a, string b)
    {
        var dict = new Dictionary<char, char>();
        bool isExchangeable = true;
        var loop = Math.Min(a.Length, b.Length);
        for (int i = 0; i < loop; i++)
        {
            if (!dict.ContainsKey(a[i]))
            {
                if (!dict.ContainsValue(b[i]))
                {
                    dict[a[i]] = b[i];
                }
                else
                {
                    isExchangeable = false;
                    return isExchangeable;
                }
            }
            else if (dict[a[i]] != b[i])
            {
                isExchangeable = false;
                return isExchangeable;
            }
            
        }
        if (a.Length < b.Length)
        {
            for (int i = loop; i <b.Length; i++)
            {
                if (!dict.ContainsValue(b[i]))
                {
                    isExchangeable = false;
                    return isExchangeable;
                }
            }
        }
        else if (a.Length > b.Length)
        {
            for (int i = loop; i < a.Length; i++)
            {
                if (!dict.ContainsKey(a[i]))
                {
                    isExchangeable = false;
                    return isExchangeable;
                }
            }
        }
        return isExchangeable;
    }
}