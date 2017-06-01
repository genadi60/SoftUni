using System;

public class TheaThePhotographer
{
    public static void Main()
    {
        var numberOfPictures = int.Parse(Console.ReadLine());
        var filterTime = long.Parse(Console.ReadLine());
        var filterFactor = int.Parse(Console.ReadLine());
        var timeToBeUploaded = long.Parse(Console.ReadLine());

        var timeToBeFiltered = numberOfPictures * filterTime;
        var usefulPictures = (int)Math.Ceiling(numberOfPictures * (filterFactor / 100.0));
        var totalTime = timeToBeFiltered + usefulPictures * timeToBeUploaded;
        var seconds = totalTime % 60;
        totalTime /= 60;
        var minutes = totalTime % 60;
        totalTime /= 60;
        var hours = totalTime % 24;
        var days = totalTime / 24;

        Console.WriteLine($"{days}:{hours:D2}:{minutes:D2}:{seconds:D2}");
    }
}