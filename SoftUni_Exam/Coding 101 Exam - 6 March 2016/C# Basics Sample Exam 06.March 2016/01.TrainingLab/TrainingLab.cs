using System;

class TrainingLab
{
    static void Main()
    {
        double w = double.Parse(Console.ReadLine());
        double h = double.Parse(Console.ReadLine());
        int col = (int)((h - 1.0) / 0.7);
        int row = (int)(w / 1.2);
        int result = row * col - 3;
        Console.WriteLine(result);
    }
}