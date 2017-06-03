using System;
using System.Collections.Generic;
using System.Text;

public class StringConcatenation
{
    public static void Main()
    {
        var delimeter = Console.ReadLine();
        var typeOfElement = Console.ReadLine();
        var numberOfStrings = int.Parse(Console.ReadLine());
        var inputStrings = new string[numberOfStrings];
        List<string> outputString = new List<string>();
        for (int i = 0; i < numberOfStrings; i++)
        {
            inputStrings[i] = Console.ReadLine();
        }
        if (typeOfElement.Equals("odd"))
        {
            for (int i = 0; i < inputStrings.Length; i += 2)
            {
                outputString.Add(inputStrings[i]);
            }
        }
        else
        {
            for (int i = 1; i <= inputStrings.Length - 1; i += 2)
            {
                outputString.Add(inputStrings[i]);
            }
        }
        Console.WriteLine(string.Join(delimeter, outputString).ToString());
    }
}