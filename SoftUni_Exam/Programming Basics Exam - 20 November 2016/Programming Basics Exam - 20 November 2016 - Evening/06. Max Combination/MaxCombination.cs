using System;

class MaxCombination
{
    static void Main()
    {
        int start = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());
        int komb = int.Parse(Console.ReadLine());
        int count = 0;
        for (int i = start; i <= end; i++)
        {
            for (int j = start; j <= end; j++)
            {
                Console.Write("<{0}-{1}>", i, j);
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