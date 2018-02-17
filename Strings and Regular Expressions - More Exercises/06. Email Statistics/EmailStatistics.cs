using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class EmailStatistics
{
    public static void Main()
    {
        var domains = new Dictionary<string,List<string>>();
        var pattern = @"(?<user>[a-zA-Z]{5,})@(?<domain>[a-z]{3,}[.](com|bg|org))\b";
        var regex = new Regex(pattern);
        var mailsNumber = int.Parse(Console.ReadLine());
        for (int i = 0; i < mailsNumber; i++)
        {
            var mail = regex.Match(Console.ReadLine());
            if (mail.Success)
            {
                var domain = mail.Groups["domain"].Value;
                var userName = mail.Groups["user"].Value;
                if (!domains.ContainsKey(domain))
                {
                    domains[domain] = new List<string>();
                }
                if (!domains[domain].Contains(userName))
                {
                    domains[domain].Add(userName);
                }
            }
        }
        foreach (var kvp in domains.OrderByDescending(x => x.Value.Count))
        {
            var domain = kvp.Key;
            Console.WriteLine($"{domain}:");
            var users = kvp.Value;
            foreach (var name in users)
            {
                var user = name;
                Console.WriteLine($"### {user}");
            }
        }
    }
}