using System;
using System.Numerics;

class FibonacciNumbers
{
    static void Main()
    {
        var inputValue = int.Parse(Console.ReadLine());
        Console.WriteLine(FibonacciCalculate(inputValue));
    }

    static BigInteger FibonacciCalculate(int n)
    {
        BigInteger firstNumber = 1;
        BigInteger secondNumber = 1;
        BigInteger result = 0;
        if (n == 0 || n == 1)
        {
            result = 1;
        }
        else
        {
            for (int i = 2; i <= n; i++)
            {
                result = firstNumber + secondNumber;
                firstNumber = secondNumber;
                secondNumber = result;
            }
        }
        return result;
    }
}