using System;

public class SumOfChars
{
    public static void Main()
    {
        var numberOfLetters = int.Parse(Console.ReadLine());
        var sum = 0;
        for (int i = 0; i < numberOfLetters; i++)
        {
            sum += Convert.ToInt32((char)Console.Read());

            Console.ReadLine();
        }
        Console.WriteLine($"The sum equals: {sum}");
    }
}