using System;

public class PrintPartOfASCIITable
{
    public static void Main()
    {
        var startCharacter = int.Parse(Console.ReadLine());
        var endCharacter = int.Parse(Console.ReadLine());
        char start = (char)startCharacter;
        char end = (char)endCharacter;
        for (char i = start; i <= end; i++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }
}