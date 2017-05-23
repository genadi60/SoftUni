using System;
using System.Numerics;

class Factorial
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        
        FindFactorial(n);
    }

    private static void FindFactorial(int n)
    {
        BigInteger factorial = 1;
        while (n >= 1)
        {
            factorial *= n;
            n--;
        }
        Console.WriteLine(factorial);
     }
}