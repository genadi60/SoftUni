using System;

public class MakeAWord
{
    public static void Main()
    {
        var numberOfLetters = int.Parse(Console.ReadLine());
        var word = string.Empty;
        for (int i = 0; i < numberOfLetters; i++)
        {
            word = word + Console.ReadLine();
        }
        Console.WriteLine($"The word is: {word}");
    }
}