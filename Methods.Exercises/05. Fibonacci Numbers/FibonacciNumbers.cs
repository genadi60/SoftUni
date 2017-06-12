using System;
using System.Numerics;

public class FibonacciNumbers
{
	public static void Main()
	{
		var n = int.Parse(Console.ReadLine());
		var b = GetFibonacci(n);
		Console.WriteLine(b);
	}

	static BigInteger GetFibonacci(int a)
	{
		BigInteger firstNumber = 0;
		BigInteger secondNumber = 0;
		BigInteger result = 1;
		
		for (int i = 0; i < a; i++)
		{
			firstNumber = secondNumber;
			secondNumber = result;
			result = firstNumber + secondNumber;
		}
		return result;
	}
}