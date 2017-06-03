using System;

public class BeerKegs
{
    public static void Main()
    {
        var numberOfKegs = int.Parse(Console.ReadLine());
        var maxVolume = decimal.MinValue;
        var outputName = string.Empty;

        for (int i = 0; i < numberOfKegs; i++)
        {
            var nameOfKeg = Console.ReadLine();
            var radius = decimal.Parse(Console.ReadLine());
            var height = int.Parse(Console.ReadLine());
            var volume = (decimal)Math.PI * radius * radius * height;
            if (volume > maxVolume)
            {
                maxVolume = volume;
                outputName = nameOfKeg;
            }
        }
        Console.WriteLine(outputName);
    }
}