using System;

class Battles
{
    static void Main()
    {
        int first = int.Parse(Console.ReadLine());
        int second = int.Parse(Console.ReadLine());
        int komb = int.Parse(Console.ReadLine());
        int count = 0;
        for (int i = 1; i <= first; i++)
        {
            for (int j = 1; j <= second; j++)
            {
                Console.Write("({0} <-> {1}) ", i, j);
                count++;
                if (count == komb)
                {
                    break;
                }
            }
            if (count == komb)
            {
                break;
            }
        }
        Console.WriteLine();
    }
}