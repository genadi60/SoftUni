using System;
using System.Numerics;
using System.Text;

public class MultiplyBigNumber
{
    public static void Main()
    {
        var firstLine = Console.ReadLine();
        var secondLine = Console.ReadLine();
        //var maxLength = Math.Max(firstLine.Length, secondLine.Length);
        //var first = firstLine.PadLeft(maxLength, '0');
        //var second = secondLine.PadLeft(maxLength, '0');
        var c = 0;
        StringBuilder multiplBigNumbers = new StringBuilder();
        multiplBigNumbers = MultiplTwoBigIntegers(firstLine, secondLine, c);
        BigInteger a = BigInteger.Parse(multiplBigNumbers.ToString());
        Console.WriteLine(a);
    }

    static StringBuilder MultiplTwoBigIntegers(string a, string b, int c)
    {
        StringBuilder bigNumber = new StringBuilder();
        for (int i = a.Length - 1; i >= 0; i--)
        {
            var firstDigit = a[i] - '0';
            var secondDigit = int.Parse(b);
            var mult = ((firstDigit * secondDigit + c) % 10);
            c = (firstDigit * secondDigit + c) / 10;
            bigNumber.Insert(0, mult);
        }
        if (c > 0)
        {
            bigNumber.Insert(0, c);
        }
        return bigNumber;
    }
}