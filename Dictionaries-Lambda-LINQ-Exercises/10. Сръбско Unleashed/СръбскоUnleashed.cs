using System;
using System.Collections.Generic;
using System.Linq;

public class СръбскоUnleashed
{
    public static void Main()
    {
        var locationConcerts = new Dictionary<string, Dictionary<string, long>>();
        while (true)
        {
            var userInput = Console.ReadLine();
            if (userInput.Equals("End"))
            {
                break;
            }
            if (!userInput.Contains(" @"))
            {
                continue;
            }
            var input = userInput.Split("@".ToCharArray()).ToArray();
            var locationTicketsTicketscount = input[1].Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToArray();
            if (locationTicketsTicketscount.Length < 3 || locationTicketsTicketscount.Length > 5)
            {
                continue;
            }
            var singerName = input[0]
                .Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToArray();
            if (singerName.Length > 3)
            {
                continue;
            }
            var singer = String.Join(" ", singerName);
            var ticketsTicketscount = locationTicketsTicketscount.Reverse().Take(2).ToArray();
            var tickets = 0;
            if (int.TryParse(ticketsTicketscount[1], out tickets))
            {
                var ticketsCount = 0;
                if (int.TryParse(ticketsTicketscount[0], out ticketsCount))
                {
                    long venues = tickets * ticketsCount;
                    var location = locationTicketsTicketscount.Reverse().Skip(2).ToList();
                    if (location.Count > 1)
                    {
                        location.Reverse();
                    }
                    var city = String.Join(" ", location);
                    if (!locationConcerts.ContainsKey(city))
                    {
                        locationConcerts[city] = new Dictionary<string, long>();
                    }
                    if (!locationConcerts[city].ContainsKey(singer))
                    {
                        locationConcerts[city][singer] = 0L;
                    }
                    locationConcerts[city][singer] += venues;
                }
            }
        }
        foreach (var kvp in locationConcerts)
        {
            var location = kvp.Key;
            var singersList = kvp.Value;
            Console.WriteLine($"{location}");
            foreach (var kvp2 in singersList.OrderByDescending(x => x.Value))
            {
                var singer = kvp2.Key;
                var venues = kvp2.Value;
                Console.WriteLine($"#  {singer} -> {venues}");
            }
        }
    }
}