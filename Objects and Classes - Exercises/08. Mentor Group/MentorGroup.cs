using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

public class MentorGroup
{
    public static void Main()
    {
        var usersDates = new SortedDictionary<string, List<DateTime>>();
        var usersComments = new Dictionary<string, List<string>>();
        while (true)
        {
            var input = Console.ReadLine();
            if (input.Equals("end of dates"))
            {
                break;
            }
            var userAndDates = input
                .Split()
                .ToArray();
            var name = userAndDates[0];
            var datesByString = new List<string>();
            if (userAndDates.Length > 1)
            {
                
                datesByString = userAndDates[1]
                    .Split(',')
                    .ToList();
            }
            
            
            if (!usersDates.ContainsKey(name))
            {
                usersDates[name] = new List<DateTime>();
            }
            for (int i = 0; i < datesByString.Count; i++)
            {
                DateTime date = new DateTime();
                date = DateTime.ParseExact(datesByString[i], "dd/MM/yyyy", CultureInfo.InvariantCulture);
                usersDates[name].Add(date);
            }
        }
        while (true)
        {
            var input = Console.ReadLine();
            if (input.Equals("end of comments"))
            {
                break;
            }
            var userAndComment = input
                .Split('-')
                .ToArray();
            var name = userAndComment[0];
            if (!usersDates.ContainsKey(name))
            {
                continue;
            }
            var comment = userAndComment[1];
            if (!usersComments.ContainsKey(name))
            {
                usersComments[name] = new List<string>();
            }
            usersComments[name].Add(comment);
        }
        foreach (var kvp in usersDates)
        {
            var name = kvp.Key;
            var dates = kvp.Value;
            Console.WriteLine($"{name}");
            Console.WriteLine("Comments:");
            
            if (usersComments.ContainsKey(name))
            {
                var comments = usersComments[name];
                foreach (var comment in comments)
                {
                    Console.WriteLine($"- {comment}");
                }
            }
            Console.WriteLine("Dates attended:");
            foreach (var d in dates.OrderBy(x => x))
            {
                Console.WriteLine($"-- {d.Day:D2}/{d.Month:D2}/{d.Year}");
            }
        }
    }
}