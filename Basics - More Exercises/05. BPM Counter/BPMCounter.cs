using System;

public class BPMCounter
{
    public static void Main()
    {
        var bpm = int.Parse(Console.ReadLine());
        var numberOfBeats = int.Parse(Console.ReadLine());
        var beatsPerSecond = bpm / 60m;
        var timeInSeconds = numberOfBeats / beatsPerSecond;
        var minutes = Math.Floor(timeInSeconds / 60);
        var seconds = Math.Floor(timeInSeconds % 60);
        var bars = numberOfBeats / 4m;

        Console.WriteLine($"{Math.Round(bars, 1)} bars - {minutes}m {seconds}s");
    }
}