using System;
using System.Collections.Generic;
using System.Linq;

public class VaporStore
{
    public static void Main()
    {
        var VideoGames = new Dictionary<string, decimal>();
        VideoGames["OutFall 4"] = 39.99m;
        VideoGames["CS: OG"] = 15.99m;
        VideoGames["Zplinter Zell"] = 19.99m;
        VideoGames["Honored 2"] = 59.99m;
        VideoGames["RoverWatch"] = 29.99m;
        VideoGames["RoverWatch Origins Edition"] = 39.99m;
        var totalSpent = 0.00m;

        var currentBalance = decimal.Parse(Console.ReadLine());
        var videoGame = Console.ReadLine();
        while (videoGame != "Game Time")
        {
            if (VideoGames.ContainsKey(videoGame))
            {
                if (currentBalance >= VideoGames[videoGame])
                {
                    currentBalance -= VideoGames[videoGame];
                    totalSpent += VideoGames[videoGame];
                    Console.WriteLine($"Bought {videoGame}");
                    if (currentBalance == 0)
                    {
                        Console.WriteLine("Out of money!");
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("Too Expensive");
                }
            }
            else
            {
                Console.WriteLine("Not Found");
            }

            videoGame = Console.ReadLine();
        }

        Console.WriteLine($"Total spent: ${totalSpent:F2}. Remaining: ${currentBalance:F2}");
    }
}