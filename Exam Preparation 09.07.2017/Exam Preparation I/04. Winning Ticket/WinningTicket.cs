using System;
using System.Linq;
using System.Text.RegularExpressions;

public class WinningTicket
{
    public static void Main()
    {
        var tickets = Console.ReadLine()
            .Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
            .Select(x => x.Trim())
            .ToArray();
        if (tickets.Length == 0)
        {
            Console.WriteLine("invalid ticket");
            return;
        }
        string[] patterns = new string[]
        {
            @"(?<first>[@]{6,10})",
            @"(?<first>[\$]{6,10})",
            @"(?<first>[#]{6,10})",
            @"(?<first>[\^]{6,10})"
        };
        var leftSide = string.Empty;
        var rightSide = string.Empty;
        for (int i = 0; i < tickets.Length; i++)
        {
            
            if (tickets[i].Length != 20)
            {
                Console.WriteLine("invalid ticket");
            }
            else
            {
                bool isSuccess = false;
                leftSide = tickets[i].Substring(0, 10);
                rightSide = tickets[i].Substring(10);
                for (int j = 0; j < patterns.Length; j++)
                {
                    var winnerTicket = new Regex(patterns[j]);
                    var resultLeft = winnerTicket.Match(leftSide);
                    var resultRight = winnerTicket.Match(rightSide);
                    if (resultLeft.Success && resultRight.Success)
                    {
                        var groupLength = Math.Min(resultLeft.Groups["first"].Length, resultRight.Groups["first"].Length);
                        char simbol = resultLeft.Groups["first"].Value.First();
                        if (groupLength == 10)
                        {
                            Console.WriteLine($@"ticket ""{tickets[i]}"" - {groupLength}{simbol} Jackpot!");
                        }
                        else
                        {
                            Console.WriteLine($@"ticket ""{tickets[i]}"" - {groupLength}{simbol}");
                        }
                        isSuccess = true;
                    }
                    
                }
                if (!isSuccess)
                {
                    Console.WriteLine($@"ticket ""{tickets[i]}"" - no match");
                }
            }
        }
    }
}
