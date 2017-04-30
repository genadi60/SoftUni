using System;

class LettersCombinations
{
    static void Main()
    {
        int start = (int)Console.Read();
        Console.ReadLine();
        int end = (int)Console.Read();
        Console.ReadLine();
        int miss = (int)Console.Read();
        int sum = 0;
        for (int i = start; i <= end; i++)
        {
            for (int j = start; j <= end; j++)
            {
                for (int k = start; k <= end; k++)
                {
                    if (i != miss && j != miss && k != miss)
                    {
                        Console.Write((char)i);
                        Console.Write((char)j);
                        Console.Write((char)k);
                        Console.Write(' ');
                        sum++;
                    }
                }
            }
        }
        Console.Write(sum);
        Console.WriteLine();
    }
}