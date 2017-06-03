using System;

public class BoatSimulator
{
    public static void Main()
    {
        var firstBoat = (char)Console.Read();

        Console.ReadLine();
        var secondBoad = (char)Console.Read();

        Console.ReadLine();
        var numberOfLines = int.Parse(Console.ReadLine());
        var firstBoatMoves = 0;
        var secondBoatMoves = 0;
        for (int i = 1; i <= numberOfLines; i++)
        {
            var move = Console.ReadLine();
            if (move.Equals("UPGRADE"))
            {
                firstBoat = (char)(firstBoat + 3);
                secondBoad = (char)(secondBoad + 3);
            }
            else
            {
                if (i % 2 != 0)
                {
                    firstBoatMoves += move.Length;
                    if (firstBoatMoves >= 50)
                    {
                        Console.WriteLine(firstBoat);
                        return;
                    }
                }
                else
                {
                    secondBoatMoves += move.Length;
                    if (secondBoatMoves >= 50)
                    {
                        Console.WriteLine(secondBoad);
                        return;
                    }
                }
            }
        }
        if (firstBoatMoves >= secondBoatMoves)
        {
            Console.WriteLine(firstBoat);
        }
        else
        {
            Console.WriteLine(secondBoad);
        }
    }
}