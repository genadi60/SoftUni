using System;

class House
{
    static void Main()
    {
        int numberOfElements = int.Parse(Console.ReadLine());
        char asterisks = '*';
        char doth = '.';
        int a = numberOfElements / 2;
        int b = -1;
        while (a > -1)
        {
            RoofDrawing(doth, asterisks, a, b, numberOfElements);
            a--;
            b += 2;
        }
        for (int k = 0; k < numberOfElements/2; k++)
        {
            WallDrawing(numberOfElements, doth, asterisks, k);
        }
    }

    static void WallDrawing(int numbersOfElements,char doth, char asterisks, int k)
    {
        for (int i = 0; i < numbersOfElements/4; i++)
        {
            Console.Write(doth);
        }
        Console.Write(asterisks);
        for (int i = 0; i < numbersOfElements - 2*(numbersOfElements / 4) - 2; i++)
        {
            if(k < numbersOfElements / 2 - 1)
            {
                Console.Write(doth);
            }
            else
            {
                Console.Write(asterisks);
            }
        }
        Console.Write(asterisks);
        for (int i = 0; i < numbersOfElements / 4; i++)
        {
            Console.Write(doth);
        }
        Console.WriteLine();
    }

    static void RoofDrawing(char doth,char asterisks, int a, int b, int n)
    {
        for (int i = a; i > 0; i--)
        {
            Console.Write(doth);
        }
        Console.Write(asterisks);
        for (int i = 0; i < b; i++)
        {
            if(b != n - 2)
            {
                Console.Write(doth);
            }
            else
            {
                Console.Write(asterisks);
            }
        }
        if(b > 0)
        {
            Console.Write(asterisks);
        }
        for (int i = a; i > 0; i--)
        {
            Console.Write(doth);
        }
        Console.WriteLine();
    }
}