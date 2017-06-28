using System;
using System.Collections.Generic;
using System.Linq;

public class TeamworkProjects
{
    public class Team
    {
        public string Name { get; set; }
        public string Creator { get; set; }
        public List<string> Members { get; set; }
    }
    public static void Main()
    {
        var teamName = new List<string>();
        var userName = new List<string>();
        var teams = new List<Team>();
        var n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            var input = Console.ReadLine()
                .Split("-".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            if (teamName.Contains(input[1]))
            {
                Console.WriteLine($"Team {input[1]} was already created!");
                continue;
            }
            if (userName.Contains(input[0]))
            {
                Console.WriteLine($"{input[0]} cannot create another team!");
                continue;
            }
            var team = new Team();
            team.Name = input[1];
            teamName.Add(team.Name);
            team.Creator = input[0];
            userName.Add(team.Creator);
            team.Members = new List<string>();
            teams.Add(team);
            Console.WriteLine($"Team {team.Name} has been created by {team.Creator}!");
        }
        while (true)
        {
            var input = Console.ReadLine();
            if (input.Equals("end of assignment"))
            {
                break;
            }
            var join = input
                .Split("->".ToCharArray(),StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            if (!teamName.Contains(join[1]))
            {
                Console.WriteLine($"Team {join[1]} does not exist!");
                continue;
            }
            if (userName.Contains(join[0]))
            {
                Console.WriteLine($"Member {join[0]} cannot join team {join[1]}!");
                continue;
            }
            foreach (var team in teams)
            {
                if (team.Name.Equals(join[1]))
                {
                    team.Members.Add(join[0]);
                }
            }
            userName.Add(join[0]);
        }
        foreach (var team in teams.OrderByDescending(x => x.Members.Count).ThenBy(x => x.Name))
        {
            if (team.Members.Count > 0)
            {
                Console.WriteLine($"{team.Name}");
                Console.WriteLine($"- {team.Creator}");
                foreach (var member in team.Members.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {member}");
                }
            }
        }
        Console.WriteLine("Teams to disband:");
        foreach (var team in teams.OrderBy(x => x.Name))
        {
            if (team.Members.Count == 0)
            {
                Console.WriteLine($"{team.Name}");
            }
        }
    }
}