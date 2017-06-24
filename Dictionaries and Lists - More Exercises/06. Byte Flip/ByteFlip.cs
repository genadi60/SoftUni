using System;
using System.Collections.Generic;
using System.Linq;

public class ByteFlip
{
    public static void Main()
    {
        var codedArray = Console.ReadLine()
            .Split()
            .Where(x => x.Length == 2)
            .ToArray();
        var finalArray = new List<string>();
        foreach (var item in codedArray)
        {
            var temp = string.Empty;
            foreach (var sign in item)
            {
                temp = sign + temp;
            }
            finalArray.Add(temp);
        }
        finalArray.Reverse();
        var charArray = finalArray
            .Select(x => Convert.ToInt32(x, 16))
            .Select(x => (char) x)
            .ToArray();
        Console.WriteLine(string.Join("", charArray));
    }
}