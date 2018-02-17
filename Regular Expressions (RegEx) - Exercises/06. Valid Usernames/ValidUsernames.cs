using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class ValidUsernames
{
    class Mails
    {
        public string UserName { get; set; }
        public int Length { get; set; }
        public int Index { get; set; }
    }
    public static void Main()
    {
        var pattern = @"\#(?<user>([a-zA-Z]+[a-zA-Z0-9_]*){3,25})\#";
        var regex = new Regex(pattern);
        var line = Console.ReadLine()
            .Split(" /\\()".ToCharArray(), StringSplitOptions
                .RemoveEmptyEntries).ToArray();
        for (int i = 0; i < line.Length; i++)
        {
            line[i] = line[i].TrimStart(" /\\()".ToCharArray()).TrimEnd(" /\\()".ToCharArray());
        }
        var ollMails = "#" + String.Join("##", line) + "#";
        MatchCollection valideMails = regex.Matches(ollMails);
        var listOfMails = new List<Mails>();
        foreach (Match mail in valideMails)
        {
            var length = mail.Groups["user"].Length;
            var name = mail.Groups["user"].Value;
            var index = mail.Groups["user"].Index;
            var valideMail = new Mails()
            {
                UserName = name,
                Length = length,
                Index = index
            };
            listOfMails.Add(valideMail);
        }
        var maxLength = 0;
        var sumTwoLength = 0;
        var user1 = string.Empty;
        var user2 = string.Empty;
        for (int i = 0; i < listOfMails.Count -1; i++)
        {
            sumTwoLength = listOfMails[i].Length + listOfMails[i + 1].Length;
            if (sumTwoLength > maxLength)
            {
                maxLength = sumTwoLength;
                user1 = listOfMails[i].UserName;
                user2 = listOfMails[i + 1].UserName;
            }
        }
        Console.WriteLine(user1);
        Console.WriteLine(user2);
    }
}