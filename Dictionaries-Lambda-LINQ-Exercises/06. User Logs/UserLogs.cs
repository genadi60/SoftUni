using System;
using System.Collections.Generic;
using System.Linq;

public class UserLogs
{
    public static void Main()
    {
        var userActivity = new SortedDictionary<string, Dictionary<string, int>>();
        var separators = new string[]{"IP=", "message=", "user="};
        var usersData = Console.ReadLine();
        while (!usersData.Equals("end"))
        {
            var userData = usersData
                .Split(separators, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            var ipAddress = userData[0];
            var userName = userData[2];
            if (!userActivity.ContainsKey(userName))
            {
                userActivity[userName] = new Dictionary<string, int>();
            }
            if (!userActivity[userName].ContainsKey(ipAddress))
            {
                userActivity[userName][ipAddress] = 0;
            }
            userActivity[userName][ipAddress]++;
            usersData = Console.ReadLine();
        }
        foreach (var kvp in userActivity)
        {
            var name = kvp.Key;
            Console.WriteLine($"{name}: ");
            bool isFirst = false;
            foreach (var kvp2 in kvp.Value)
            {
                var ip = kvp2.Key;
                var count = kvp2.Value;
                if (isFirst)
                {
                    Console.Write(", ");
                }
                Console.Write($"{ip}=> {count}");
                isFirst = true;
            }
            Console.Write(".\n");
        }
    }
}