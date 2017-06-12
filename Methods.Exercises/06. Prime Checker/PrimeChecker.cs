using System;

public class PrimeChecker
{
	public static void Main()
	{
		var num = long.Parse(Console.ReadLine());
		Console.WriteLine(IsPrime(num));
	}

	static bool IsPrime(long a)
	{
		var isPrime = true;
		if (a > 1)
		{
			for (int i = 2; i <= Math.Sqrt(a); i++)
			{
				if (a % i == 0)
				{
					isPrime = false;
				}
			}
		}
		else
		{
			isPrime = false;
		}
		
		return isPrime;
	}
}