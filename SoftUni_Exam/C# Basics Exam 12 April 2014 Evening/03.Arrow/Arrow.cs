using System;

class Arrow
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        PrintBody(size);
        int a = 1;
        int b = 2 * size - 5;
        while (b > -3)
        {
            PrinArrow(a, b);
            a++;
            b -= 2;
        }
    }

    static void PrinArrow(int a, int b)
    {
        for (int i = 0; i < a; i++)
        {
            Console.Write('.');
        }
        Console.Write('#');
        for (int i = 0; i < b; i++)
        {
            Console.Write('.');
        }
        if( b > -1)
        {
            Console.Write('#');
        }
        for (int i = 0; i < a; i++)
        {
            Console.Write('.');
        }
        Console.WriteLine();
    }

    static void PrintBody(int size)
    {
        for (int i = 0; i < size; i++)
        {
            for (int k = 0; k < size / 2; k++)
            {
                if (i != size - 1)
                {
                    Console.Write('.');
                }
                else
                {
                    Console.Write('#');
                }   
            }
            Console.Write('#');

            for (int k = 0; k < size - 2; k++)
            {
                if (i != 0)
                {
                    Console.Write('.');
                }
                else
                {
                    Console.Write('#');
                }
            }
            Console.Write('#');

            for (int k = 0; k < size / 2; k++)
            {
                if (i != size - 1)
                {
                    Console.Write('.');
                }
                else
                {
                    Console.Write('#');
                }
            }
        Console.WriteLine();
        }
    }
}