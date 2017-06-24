using System;
using System.Collections.Generic;

public class ImmuneSystem
{
    public static void Main()
    {
        var virusesCounter = new List<string>();
        var initialHealt = int.Parse(Console.ReadLine());
        var currentHealt = initialHealt;
        while (true)
        {
            var virus = Console.ReadLine();
            if (virus.Equals("end"))
            {
                break;
            }
            var virusStrength = VirusStrength(virus);
            var timeToDefeat = virusStrength * virus.Length;
            if (virusesCounter.Contains(virus))
            {
                timeToDefeat = (int)(timeToDefeat / 3.0);
            }
            else
            {
                virusesCounter.Add(virus);
            }
            Console.WriteLine($"Virus {virus}: {virusStrength} => {timeToDefeat} seconds");
            currentHealt = currentHealt - timeToDefeat;
            if (currentHealt <= 0)
            {
                Console.WriteLine("Immune System Defeated.");
                return;
            }
            var defeatMinutes = timeToDefeat / 60;
            var defeatSeconds = timeToDefeat % 60;
            Console.WriteLine($"{virus} defeated in {defeatMinutes}m {defeatSeconds}s.");
            Console.WriteLine($"Remaining health: {currentHealt}");
            currentHealt = (int)Math.Min((currentHealt * 1.2), initialHealt);
            
        }
        Console.WriteLine($"Final Health: {currentHealt}");
    }

    static int VirusStrength(string virus)
    {
        var strength = 0;
        foreach (var sign in virus)
        {
            strength += sign;
        }
        return (int)(strength / 3.0);
    }
}