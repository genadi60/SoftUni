using System;

public class ComparingFloats
{
    public const double eps = 0.000001;
    public static void Main()
    {
        var firstNumber = double.Parse(Console.ReadLine());
        var secondNumber = double.Parse(Console.ReadLine());
        bool equal = true;
        if (Math.Abs(firstNumber - secondNumber) >= eps)
        {
            equal = false;
        }
        Console.WriteLine(equal);
    }
}