using System;

public class IntegerToHexAndBinary
{
    public static void Main()
    {
        var userInput = int.Parse(Console.ReadLine());
        Console.WriteLine((Convert.ToString(userInput, 16)).ToUpper());
        Console.WriteLine(Convert.ToString(userInput, 2));
    }
}