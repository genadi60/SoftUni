using System;

class RefactorVolumeOfPyramid
{
    static void Main()
    {
        double lenght, height, width = 0.0;
        Console.Write("Length: ");
        lenght = double.Parse(Console.ReadLine());
        Console.Write("Width: ");
        width = double.Parse(Console.ReadLine());
        Console.Write("Height: ");
        height = double.Parse(Console.ReadLine());
        double volume = (lenght * height * width) / 3.0;
        Console.WriteLine("Pyramid Volume: {0:F2}", volume);
        
    }
}