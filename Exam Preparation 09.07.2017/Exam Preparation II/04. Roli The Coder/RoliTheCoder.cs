using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

class RoliTheCoder
{
    class Events
    {
        public string Name { get; set; }
        public List<string> Members { get; set; }
    }
    static void Main()
    {
        var eventsList = new Dictionary<string, List<Events>>();
        while (true)
        {
            var ev = new Events()
            {
                Name = string.Empty,
                Members = new List<string>()
            };
            var input = Console.ReadLine();
            if (input == "Time for Code")
            {
                break;
            }
            var eventParticipants = input
                .Split("@".ToCharArray())
                .Select(x => x.Trim())
                .ToArray();
            if (eventParticipants.Length < 2)
            {
                continue;
            }
            var eventID = eventParticipants[0]
                .Split(" #".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            if (eventID.Length < 2)
            {
                continue;
            }
            var id = eventID[0];
            var eventName = eventID[1];
            var invalidParticipant = @"[^a-zA-Z0-9\'\-]";
            var invalid = new Regex(invalidParticipant);
            bool isValid = false;
            for (int i = 1; i < eventParticipants.Length; i++)
            {
                var inv = invalid.Match(eventParticipants[i]);
                if (inv.Success)
                {
                    isValid = true;
                }
                else
                {
                    ev.Members.Add(eventParticipants[i]);
                }
            }
            if (isValid)
            {
                isValid = false;
                continue;
            }
            ev.Name = eventName;
            if (!eventsList.ContainsKey(id))
            {
                eventsList[id] = new List<Events>();
                eventsList[id].Add(ev);
            }
            var existEvents = eventsList[id];
            foreach (var e in existEvents)
            {
                if (e.Name.Equals(eventName))
                {
                    e.Members.AddRange(ev.Members);
                }
                else
                {
                    continue;
                }
            }
        }
    }
}