using System;
using System.Collections.Generic;
using System.Linq;

public class FoldAndSum
{
    public static void Main()
    {
        var lst = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();
        var k = lst.Count / 4;
        var left = lst
            .Take(k)
            .Reverse();
        var right = lst
            .Skip(3 * k)
            .Take(k)
            .Reverse();
        var upper = left.Concat(right).ToList();
        var bottom = lst
            .Skip(k)
            .Take(2 * k)
            .ToList();
        var sum = new List<int>();
        for (int i = 0; i < 2 * k; i++)
        {
            sum.Add(upper[i] + bottom[i]);
        }
        Console.WriteLine(string.Join(" ", sum));
    }
}