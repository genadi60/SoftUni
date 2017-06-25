using System;
using System.Linq;

public class RandomizeWords
{
    public static void Main()
    {
        var inputString = Console.ReadLine()
            .Split()
            .ToArray();
        var rand = new Random();
        for (int i = 0; i < inputString.Length; i++)
        {
            var index = rand.Next(i, inputString.Length);
            var temp = inputString[i];
            inputString[i] = inputString[index];
            inputString[index] = temp;
         
            Console.WriteLine(inputString[i]);
        }
    }
}