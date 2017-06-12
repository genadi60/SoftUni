using System;
using System.Collections.Generic;

public class PrimesInGivenRange
{
	public static void Main()
	{
		var start = int.Parse(Console.ReadLine());
		var end = int.Parse(Console.ReadLine());
		Console.WriteLine(String.Join(", ", FindPrimesInRange(start, end)));
	}

	static List<int> FindPrimesInRange(int startNum, int endNum)
	{
		List<int> primesInRange = new List<int>();
		for (int i = startNum; i <= endNum; i++)
		{
			if (IsPrime(i))
			{
				primesInRange.Add(i);
			}
		}
		return primesInRange;
	}

	static bool IsPrime(int a)
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