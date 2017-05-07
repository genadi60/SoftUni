using System;
using System.Collections.Generic;

class FootballLeague
{
    static void Main()
    {
        List<string> league = new List<string> { };
        List<int> goals = new List<int> { };
        List<int> score = new List<int> { };
        string keys = Console.ReadLine();
        string match = Console.ReadLine();
        string key = "щ";
        match = match.Replace(keys, key);
        while (match != "final")
        {
            string[] containRezult = match.Substring(match.LastIndexOf(key) + 1).Split(' ');
            string[] rezult = containRezult[1].Split(':');
            string temp = string.Empty;
            foreach (char a in rezult[0])
            {
                if (a >= '0' && a <= '9')
                {
                    temp += a;
                }
            }
            int firstTeamGoals = int.Parse(temp);
            int secondTeamGoals = int.Parse(rezult[1]);
            temp = match.Remove(match.LastIndexOf(key), match.Length - (match.LastIndexOf(key)));
            char[] secTeam = temp.Substring(temp.LastIndexOf(key) + 1).ToCharArray();
            Array.Reverse(secTeam);
            string secondTeam = string.Empty;
            for (int i = 0; i < secTeam.Length; i++)
            {
                secondTeam += secTeam[i];
            }
            secondTeam = secondTeam.ToUpper();
            temp = temp.Remove(temp.LastIndexOf(key) , temp.Length - (temp.LastIndexOf(key)));
            temp = temp.Remove(temp.LastIndexOf(key) , temp.Length - (temp.LastIndexOf(key)));
            char[] firTeam = temp.Substring(temp.LastIndexOf(key) + 1).ToCharArray();
            Array.Reverse(firTeam);
            string firstTeam = string.Empty;
            for (int i = 0; i < firTeam.Length; i++)
            {
                firstTeam += firTeam[i];
            }
            firstTeam = firstTeam.ToUpper();
            int firstTeamScore = 0;
            int secondTeamScore = 0;
            if (firstTeamGoals == secondTeamGoals)
            {
                firstTeamScore++;
                secondTeamScore++;
            }
            else if (firstTeamGoals > secondTeamGoals)
            {
                firstTeamScore += 3;
            }
            else if(firstTeamGoals < secondTeamGoals)
            {
                secondTeamScore += 3;
            }
            if (league.Contains(firstTeam))
            {
                goals[league.IndexOf(firstTeam)] += firstTeamGoals;
                score[league.IndexOf(firstTeam)] += firstTeamScore;
            }
            else
            {
                league.Add(firstTeam);
                goals.Add(firstTeamGoals);
                score.Add(firstTeamScore);
            }
            if (league.Contains(secondTeam))
            {
                goals[league.IndexOf(secondTeam)] += secondTeamGoals;
                score[league.IndexOf(secondTeam)] += secondTeamScore;
            }
            else
            {
                league.Add(secondTeam);
                goals.Add(secondTeamGoals);
                score.Add(secondTeamScore);
            }
            match = Console.ReadLine();
            match = match.Replace(keys, key);
        }
        List<int> tempScore = new List<int> { };
        tempScore.AddRange(score);
        tempScore.Sort();
        tempScore.Reverse();
        string[] leagueStandings = new string[league.Count];
        List<string> tempLeague = new List<string> { };
        tempLeague.AddRange(league);
        for (int i = 0; i < league.Count; i++)
        {
            leagueStandings[i] = tempLeague[score.IndexOf(tempScore[i])];
            tempLeague.RemoveAt(score.IndexOf(tempScore[i]));
            score.RemoveAt(score.IndexOf(tempScore[i]));
        }
        for (int i = 0; i < tempScore.Count; i++)
        {
            if (i != 0 && tempScore[i] == tempScore[i - 1])
            {
               
                bool count = false;
                if (i < tempScore.Count && tempScore[i] == tempScore[i - 1])
                {
                    if (String.Compare(leagueStandings[i], leagueStandings[i - 1]) < 0)
                    {
                        string lSTemp = leagueStandings[i];
                        leagueStandings[i] = leagueStandings[i - 1];
                        leagueStandings[i - 1] = lSTemp;
                        count = true;
                    }
                }
                if (count)
                {
                    i = 0;
                }
            }
        }
        Console.WriteLine("League standings:");
        for (int i = 0; i < leagueStandings.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {leagueStandings[i]} {tempScore[i]}");
            }
        List<int> tempGoals = new List<int> { };
        tempGoals.AddRange(goals);
        tempGoals.Sort();
        tempGoals.Reverse();
        string[] scoredGoals = new string[tempGoals.Count];
        tempLeague.AddRange(league);
        for (int i = 0; i < tempGoals.Count; i++)
        {
            scoredGoals[i] = tempLeague[goals.IndexOf(tempGoals[i])];
            tempLeague.RemoveAt(goals.IndexOf(tempGoals[i]));
            goals.RemoveAt(goals.IndexOf(tempGoals[i]));
            
        }
        for (int i = 0; i < tempGoals.Count; i++)
        {
            if (i != 0 && tempGoals[i] == tempGoals[i - 1])
            {

                bool count = false;
                if (i < tempGoals.Count && tempGoals[i] == tempGoals[i - 1])
                {
                    if (String.Compare(scoredGoals[i], scoredGoals[i - 1]) < 0)
                    {
                        string sGTemp = scoredGoals[i];
                        scoredGoals[i] = scoredGoals[i - 1];
                        scoredGoals[i - 1] = sGTemp;
                        count = true;
                    }
                }
                if (count)
                {
                    i = 0;
                }
            }
        }
        int numberTop = 3;
        Console.WriteLine($"Top {numberTop} scored goals:");
        for (int i = 0; i < numberTop && i < scoredGoals.Length; i++)
        {
            Console.WriteLine($"- {scoredGoals[i]} -> {tempGoals[i]}");
        }
    }
}