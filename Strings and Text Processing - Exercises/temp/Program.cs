using System;
using System.Numerics;


public class SumBigNumbers
{
    public static void Main()
    {
        BigInteger firstLine = BigInteger.Parse(Console.ReadLine());
        BigInteger secondLine = BigInteger.Parse(Console.ReadLine());
        BigInteger sum = firstLine + secondLine;
        Console.WriteLine(sum);
    }
}
