using System;

public class Megapixels
{
    
    public static void Main(string[] args)
    {
        var width = int.Parse(Console.ReadLine());
        var heigh = int.Parse(Console.ReadLine());
        Console.WriteLine($"{width}x{heigh} => {Math.Round(((width * heigh) / 1000000m), 1)}MP");
    }
}