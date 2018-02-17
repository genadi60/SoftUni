using System;
using System.Linq;
using System.Numerics;

public class SinoTheWalker
{
    public static void Main()
    {
        var leaveTime = Console.ReadLine()
            .Split(":".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
            .ToArray();
        var leaveHour = int.Parse(leaveTime[0]);
        var leaveMinutes = int.Parse(leaveTime[1]);
        var leaveSeconds = int.Parse(leaveTime[2]);
        var leaveTimeInSeconds = leaveHour * 3600 + leaveMinutes * 60 + leaveSeconds;
        var steps = long.Parse(Console.ReadLine());
        var secondsPS = long.Parse(Console.ReadLine());
        long timeToWalk = steps * secondsPS;
        long timeToArrivalInSeconds = timeToWalk + leaveTimeInSeconds;
        var seconds = timeToArrivalInSeconds % 60;
        timeToArrivalInSeconds = timeToArrivalInSeconds / 60;
        var minuts = timeToArrivalInSeconds % 60;
        timeToArrivalInSeconds = timeToArrivalInSeconds / 60;
        var hours = timeToArrivalInSeconds % 24;
        var days = timeToArrivalInSeconds / 24;
        Console.WriteLine($"Time Arrival: {hours:D2}:{minuts:D2}:{seconds:D2}");
    }
}