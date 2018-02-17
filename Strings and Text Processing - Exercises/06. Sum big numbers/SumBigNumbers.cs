using System;
using System.Numerics;
using System.Text;

public class SumBigNumbers
{
    public static void Main()
    {
        var firstLine = Console.ReadLine();
        var secondLine = Console.ReadLine();
        var maxLength = Math.Max(firstLine.Length, secondLine.Length);
        var first = firstLine.PadLeft(maxLength, '0');
        var second = secondLine.PadLeft(maxLength, '0');
        var c = 0;
        StringBuilder sumBigNumbers = new StringBuilder();
        sumBigNumbers = SumTwoBigIntegers(first, second, c);
        BigInteger a = BigInteger.Parse(sumBigNumbers.ToString());
        Console.WriteLine(a);
    }

    static StringBuilder SumTwoBigIntegers(string a, string b, int c)
    {
        StringBuilder bigNumber = new StringBuilder();
        for (int i = a.Length -1; i >= 0; i--)
        {
            var firstDigit = a[i] - '0';
            var secondDigit = b[i] - '0';
            var sum = ((firstDigit + secondDigit + c) % 10);
            c = (firstDigit + secondDigit + c) / 10;
            bigNumber.Insert(0, sum);
        }
        if (c > 0)
        {
            bigNumber.Insert(0, c);
        }
        return bigNumber;
    }
}