using System;
using System.Linq;

public class LargestCommonEnd
{
	public static void Main()
	{
		string[] firstStrig = Console.ReadLine()
			.Split(new []{' '},StringSplitOptions.RemoveEmptyEntries)
			.ToArray();
		string[] secondStrig = Console.ReadLine()
			.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
			.ToArray();
		var leftSide = LeftLargestCommonEnds(firstStrig, secondStrig);
		var rightSide = RightLargestCommonEnds(firstStrig, secondStrig);
		if (leftSide != 0)
		{
			Console.WriteLine($"{leftSide}");
		}
		else if (rightSide != 0)
		{
			Console.WriteLine($"{rightSide}");
		}
		else
		{
			Console.WriteLine(0);
		}
	}

	static int RightLargestCommonEnds(string[] a, string[] b)
	{
		var rightLargestEnds = string.Empty;
		var isEqual = 0;
		for (int i = 1; i <= Math.Min(a.Length, b.Length); i++)
		{
			if (a[a.Length - i].Equals(b[b.Length - i]))
			{
				isEqual++;
			}
			else
			{
				if (!a[a.Length - 1].Equals(b[b.Length - 1]))
				{
					return isEqual;
				}
			}
		}
		return isEqual;
	}

	static int LeftLargestCommonEnds(string[] a, string[] b)
	{
		int isEqual = 0;
		for (int i = 0; i < Math.Min(a.Length, b.Length); i++)
		{
			if (a[i].Equals(b[i]))
			{
				isEqual++;
			}
			else
			{
				if (!a[0].Equals(b[0]))
				{
					return isEqual;
				}
			}
		}
		return isEqual;
	}
}