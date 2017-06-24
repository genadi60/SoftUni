using System;
using System.Collections.Generic;
using System.Linq;

public class HandsOfCards
{
    public static void Main()
    {
        var players = new Dictionary<string, List<int>>();
        var commands = Console.ReadLine();
        while (!commands.Equals("JOKER"))
        {
            var playerWithCards = commands
                .Split(':')
                .ToArray();
            var player = playerWithCards[0];
            var cards = playerWithCards[1]
                .Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .Select(x => CardValue(x))
                .ToArray();
            if (!players.ContainsKey(player))
            {
                players[player] = new List<int>();
            }
            players[player].AddRange(cards);
            commands = Console.ReadLine();
        }
        foreach (var kvp in players)
        {
            var name = kvp.Key;
            var card = kvp.Value;
            var sum = card.Distinct().Sum();

            Console.WriteLine($"{name}: {sum}");
        }
    }

    static int CardValue(string x)
    {
        var multiplicator = x.Substring(x.Length - 1);
        var power = x.Substring(0, (x.Length - 1));
        var multiplier1 = 1;
        switch (multiplicator)
        {
            case "S":
                multiplier1 = 4;
                break;
            case "H":
                multiplier1 = 3;
                break;
            case "D":
                multiplier1 = 2;
                break;
        }
        var multiplier2 = 0;
        switch (power)
        {
            case "J":
                multiplier2 = 11;
                break;
            case "Q":
                multiplier2 = 12;
                break;
            case "K":
                multiplier2 = 13;
                break;
            case "A":
                multiplier2 = 14;
                break;
            default:
                multiplier2 = int.Parse(power);
                break;
        }
        var result = multiplier1 * multiplier2;
        return result;
    }
}