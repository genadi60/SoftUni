using System;
using System.Text.RegularExpressions;

public class EmailMe
{
    public static void Main()
    {
        var pattern = @"^(?<firstPart>.*?)@(?<secondPart>.*?)$";
        var characterSums = Regex.Match(Console.ReadLine(), pattern);
        var firstSum = 0;
        var secondSum = 0;
        foreach (char c in characterSums.Groups["firstPart"].Value)
        {
            firstSum += (int) c;
        }
        foreach (char c in characterSums.Groups["secondPart"].Value)
        {
            secondSum += (int)c;
        }
        if ((firstSum - secondSum) >= 0)
        {
            Console.WriteLine("Call her!");
        }
        else
        {
            Console.WriteLine("She is not the one.");
        }
    }
}