using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class NetherRealms
{
    class Demon
    {
        public int Healt { get; set; }
        public double Damage { get; set; }
    }
    public static void Main()
    {
        var demons = new Dictionary<string, Demon>();
        var patternDouble = @"([-]?[0-9]+[\.][0-9]+)";
        var patternDigit = @"[-]?\d+";
        var patternLetters = @"[^\/\*\+\-\.0-9]"; 
        var patternSimbol = @"[\*\/]";
        var demonNames = Console.ReadLine()
            .Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
            .Select(x => x.Trim())
            .ToArray();
        var withOutDouble = string.Empty;
        var healt = 0;
        var damage = 0.0;
        foreach (var name in demonNames)
        {

            var simbols = Regex.Matches(name, patternSimbol)
                .Cast<Match>()
                .Select(x => x.Value)
                .ToArray();

            var characters = Regex.Matches(name, patternLetters)
                .Cast<Match>()
                .Select(x => x.Value)
                .ToArray();

            var doubleNumbers = Regex.Matches(name, patternDouble)
                .Cast<Match>()
                .Select(x => x.Value)
                .Select(double.Parse)
                .ToArray();

            withOutDouble = Regex.Replace(name, patternDouble, "");
            var numbers = Regex.Matches(withOutDouble, patternDigit)
                .Cast<Match>()
                .Select(x => x.Value)
                .Select(int.Parse)
                .ToArray();

            var charactersString = String.Join("", characters);
            foreach (var letter in charactersString)
            {
                healt += (int)letter;
            }

            foreach (var dig in numbers)
            {
                damage += dig;
            }
            foreach (var doub in doubleNumbers)
            {
                damage += doub;
            }
            var operators = String.Join("", simbols);
            foreach (var op in operators)
            {
                if (op == '*')
                {
                    damage *= 2.0;
                }
                if (op == '/')
                {
                    damage /= 2.0;
                }
            }
            var demon = new Demon()
            {
                Healt = healt,
                Damage = damage
            };
            if (!demons.ContainsKey(name))
            {
                demons[name] = demon;
            }
            healt = 0;
            damage = 0.0;
        }
        foreach (var kvp in demons.OrderBy(x => x.Key))
        {
            var name = kvp.Key;
            healt = kvp.Value.Healt;
            damage = kvp.Value.Damage;
            Console.WriteLine($"{name} - {healt} health, {damage:F2} damage");
        }
    }
}