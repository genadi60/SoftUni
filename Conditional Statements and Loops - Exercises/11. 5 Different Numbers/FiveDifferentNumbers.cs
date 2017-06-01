using System;

class FiveDifferentNumbers
{
    static void Main()
    {
        var startNumber = int.Parse(Console.ReadLine());
        var endNumber = int.Parse(Console.ReadLine());
        if (Math.Abs(startNumber - endNumber) >= 4)
        {
            for (int i = startNumber; i <= endNumber - 4; i++)
            {
                for (int j = startNumber + 1; j <= endNumber - 3; j++)
                {
                    for (int k = startNumber + 2; k <= endNumber - 2; k++)
                    {
                        for (int l = startNumber + 3; l <= endNumber - 1; l++)
                        {
                            for (int m = startNumber + 4; m <= endNumber; m++)
                            {
                                if (i < j && j < k && k < l && l < m)
                                {
                                    Console.WriteLine($"{i} {j} {k} {l} {m}");
                                }

                            }
                        }
                    }
                }
            }
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}