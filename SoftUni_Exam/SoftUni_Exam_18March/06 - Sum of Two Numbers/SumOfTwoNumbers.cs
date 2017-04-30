using System;

class SumOfTwoNumbers
{
    static void Main()
    {
        int startNumber = int.Parse(Console.ReadLine());
        int endNumber = int.Parse(Console.ReadLine());
        int magicNumber = int.Parse(Console.ReadLine());
        int count = 0;
        bool magic = true;
        
        for (int i = startNumber; i <= endNumber; i++)
        {
            for (int j = startNumber; j <= endNumber; j++)
            {
                count++;
                if ((i + j) == magicNumber)
                {
                    Console.WriteLine("Combination N:{0} ({1} + {2} = {3})", count, i, j, magicNumber);
                    magic = false;
                    break;
                }

            }
            if (!magic)
            {
                break;
            }
        }
        if (magic)
        {
            Console.WriteLine("{0} combinations - neither equals {1}", count, magicNumber);
        }
        
    }
}