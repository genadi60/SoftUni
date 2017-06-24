using System;
using System.Collections.Generic;
using System.Linq;

public class LogsAggregator
{
    public static void Main()
    {
        var user = new SortedDictionary<string, int>();
        var ipAddresses = new Dictionary<string, List<string>>();
        var numberOfAddresses = int.Parse(Console.ReadLine());
        while (numberOfAddresses > 0)
        {
            var userData = Console.ReadLine()
                .Split()
                .ToArray();
            var ip = userData[0];
            var name = userData[1];
            var duration = int.Parse(userData[2]);
            if (!user.ContainsKey(name))
            {
                user[name] = 0;
            }
            user[name] += duration;
            if (!ipAddresses.ContainsKey(name))
            {
                ipAddresses[name] = new List<string>();
            }
            ipAddresses[name].Add(ip);
            numberOfAddresses--;
        }
        foreach (var kvp in user)
        {
            var userName = kvp.Key;
            var time = kvp.Value;
            var userIP = ipAddresses[userName].Distinct().ToList();
            userIP.Sort();
            var outputIPAddresses = String.Join(", ", userIP);
            Console.WriteLine($"{userName}: {time} [{outputIPAddresses}]");
        }
    }
}