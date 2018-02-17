using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class SoftUniKaraoke
{
    public static void Main()
    {
        var awarded = new Dictionary<string, List<string>>();
        var participants = Regex.Split(Console.ReadLine(), @"\s*,\s*");
        var singerSongName = Console.ReadLine()
            .Split(',')
            .Select(x => x.Trim())
            .ToArray();
        while (true)
        {
            var participantSongAward = Console.ReadLine();
            if (participantSongAward == "dawn")
            {
                break;
            }
            if (participantSongAward != "")
            {
                var participant = Regex.Split(participantSongAward, @"\s*,\s*");
                var participantName = string.Empty;
                var songName = string.Empty;
                var award = string.Empty;
                if (participant.Length == 3)
                {
                    participantName = participant[0];
                    songName = participant[1];
                    award = participant[2];
                }
                if (participants.Contains(participantName) && singerSongName.Contains(songName))
                {
                    if (!awarded.ContainsKey(participantName))
                    {
                        awarded[participantName] = new List<string>();
                    }
                    if (!awarded[participantName].Contains(award))
                    {
                        awarded[participantName].Add(award);
                    }
                }
            }
        }
        if (awarded.Count == 0)
        {
            Console.WriteLine("No awards");
            return;
        }
        var result = awarded
            .Select(x => new
            {
                singer = x.Key,
                awards = x.Value.Distinct().OrderBy(aw => aw),
                awardscount = x.Value.Distinct().Count()
            })
            .OrderByDescending(awC => awC.awardscount)
            .ThenBy(s => s.singer)
            .ToArray();
        foreach (var sing in result)
        {
            var singerName = sing.singer;
            var awCount = sing.awardscount;
            Console.WriteLine($"{singerName}: {awCount} awards");
            foreach (var aw in sing.awards)
            {
                Console.WriteLine($"--{aw}");
            }
        }
        //foreach (var kvp in awarded.OrderByDescending(y => y.Value.Count).ThenBy(y => y.Key))
        //{
        //    var name = kvp.Key;
        //    var awards = kvp.Value;
        //    var awardsNumber = kvp.Value.Count;
        //    Console.WriteLine($"{name}: {awardsNumber} awards");
        //    foreach (var award in awards)
        //    {
        //        Console.WriteLine($"--{award}");
        //    }
        //}
    }
}
