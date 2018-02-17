using System;

public class CharityMarathon
{
    public static void Main()
    {
        var days = int.Parse(Console.ReadLine());
        var candidates = int.Parse(Console.ReadLine());
        var lapsNumber = int.Parse(Console.ReadLine());
        var lapLength =long.Parse(Console.ReadLine());
        var capacityOfTrack = int.Parse(Console.ReadLine());
        var money = decimal.Parse(Console.ReadLine());
        var runnersNumber = 0;
        var distance = 0L;
        for (int i = 0; i < days; i++)
        {
            if (candidates <= capacityOfTrack)
            {
                runnersNumber = candidates;
            }
            else
            {
                runnersNumber = capacityOfTrack;
            }
            candidates -= runnersNumber;
            distance += runnersNumber * lapsNumber * lapLength;
            if (candidates <= 0)
            {
                break;
            }
        }
        var totalMoney = distance / 1000.00m * money;
        Console.WriteLine($"Money raised: {totalMoney:F2}");
    }
}