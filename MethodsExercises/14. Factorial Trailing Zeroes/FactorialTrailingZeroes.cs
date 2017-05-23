using System;
using System.Numerics;

class FactorialTrailingZeroes
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());

        FindFactorialTrailingZeroes(n);
    }

    private static void FindFactorialTrailingZeroes(int n)
    {
        BigInteger factorial = 1;
        while (n >= 1)
        {
            factorial *= n;
            n--;
        }
        Console.WriteLine(factorial.ToString().Length - factorial.ToString().TrimEnd('0').Length);
    }
}