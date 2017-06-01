using System;

public class ReversedChars
{
    public static void Main()
    {
        string result = string.Empty;
        for (int i = 0; i < 3; i++)
        {
            result = Console.ReadLine() + result;
        }

        Console.WriteLine(result);
    }
}