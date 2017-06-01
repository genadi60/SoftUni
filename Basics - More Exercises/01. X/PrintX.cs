using System;

class PrintX
{
    static void Main()
    {
        var size = int.Parse(Console.ReadLine());
        var a = size - 2;
        char b = 'x';
        while (a > 0)
        {
            for (int i = 0; i <= size / 2; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }
                Console.Write(b);

                if (i < size / 2)
                {
                    for (int j = a; j > 0; j--)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(b);
                    a -= 2;
                }
                
                Console.WriteLine();
            }
        }
        a = 1;
        while (a < size)
        {
            for (int i = 1; i <= size / 2; i++)
            {
                for (int j = (size / 2 - 1) - i; j >= 0; j--)
                {
                    Console.Write(" ");
                }
                Console.Write(b);

                for (int j = 0; j < a; j++)
                {
                    Console.Write(" ");
                }
                Console.Write(b);
                a += 2;

                Console.WriteLine();
            }
        }
    }
}

