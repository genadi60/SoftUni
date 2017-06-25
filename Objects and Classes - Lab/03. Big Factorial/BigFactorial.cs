using System;
using System.Numerics;

public class BigFactorial
{
    public static void Main()
    {
        var inputNumber = int.Parse(Console.ReadLine());
        BigInteger bigFactorial = 1;
        for (int i = 2; i <= inputNumber; i++)
        {
            bigFactorial *= i;
        }
        Console.WriteLine(bigFactorial);
    }
}