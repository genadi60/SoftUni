using System;

public class StringsAndObjects
{
    public static void Main()
    {
        var userInput1 = Console.ReadLine();
        var userInput2 = Console.ReadLine();
        object greeting = $"{userInput1} {userInput2}";
        string result = (string)greeting;
        Console.WriteLine(result);
    }
}