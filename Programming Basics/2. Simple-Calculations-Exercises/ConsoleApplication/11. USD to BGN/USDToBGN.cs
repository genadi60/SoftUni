using System;

class USDToBGN
{
    static void Main()
    {
        var usd = decimal.Parse(Console.ReadLine());
        var bgn = usd * 1.79549M;
        Console.WriteLine("{0:F2} BGN", bgn);
    }
}