using System;

class MagicLetter
{
    static void Main()
    {
        var startLetter = Console.ReadLine().ToLower().ToCharArray();
        var endLetter = Console.ReadLine().ToLower().ToCharArray();
        var missLetter = Console.ReadLine().ToLower().ToCharArray();
        for (var i = startLetter[0]; i <= endLetter[0]; i++)
        {
            for (var j = startLetter[0]; j <= endLetter[0]; j++)
            {
                for (var k = startLetter[0]; k <= endLetter[0]; k++)
                {
                    if (i != missLetter[0] && j != missLetter[0] && k != missLetter[0])
                    {
                        Console.Write($"{i}{j}{k} ");
                    }
                }
            }
        }
        Console.WriteLine();
    }
}