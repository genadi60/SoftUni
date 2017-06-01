using System;

public class PhotoGallery
{
    public static void Main()
    {
        var numberPhoto = int.Parse(Console.ReadLine());
        var day = int.Parse(Console.ReadLine());
        var month = int.Parse(Console.ReadLine());
        var year = int.Parse(Console.ReadLine());
        var hours = int.Parse(Console.ReadLine());
        var minutes = int.Parse(Console.ReadLine());
        var sizePhoto = int.Parse(Console.ReadLine());
        var widthPhoto = int.Parse(Console.ReadLine());
        var heightPhoto = int.Parse(Console.ReadLine());
        var size = string.Empty;
        if (sizePhoto < 1000)
        {
            size = sizePhoto + "B";
        }
        else if (sizePhoto >= 1000 && sizePhoto < 1000000)
        {
            size = (Math.Round(sizePhoto / 1000m, 1)) + "KB";
        }
        else
        {
            size = (Math.Round(sizePhoto / 1000000m, 1)) + "MB";
        }
        var resolution = string.Empty;
        if (widthPhoto == heightPhoto)
        {
            resolution = "square";
        }
        else if (widthPhoto > heightPhoto)
        {
            resolution = "landscape";
        }
        else
        {
            resolution = "portrait";
        }

        Console.WriteLine($"Name: DSC_{numberPhoto:D4}.jpg");
        Console.WriteLine($"Date Taken: {day:D2}/{month:D2}/{year:D4} {hours:D2}:{minutes:D2}");
        Console.WriteLine($"Size: {size}");
        Console.WriteLine($"Resolution: {widthPhoto}x{heightPhoto} ({resolution})");
    }
}