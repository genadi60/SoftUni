using System;

class WineGlass
{
    static void Main()
    {
        int sizeOfGlass = int.Parse(Console.ReadLine());
        int asterisks = sizeOfGlass - 2;
        int dots = 0;
        while (asterisks != -2)
        {
            DrawWineGlass(dots, asterisks);
            asterisks -= 2;
            dots++;
            Console.WriteLine();
        }
        int k = sizeOfGlass >= 12 ? 2 : 1;
        DrawStem(dots, sizeOfGlass, k);
       
    }

    static void DrawStem(int dots,int n, int k)
    {
        for (int i = 0; i < n / 2 - k; i++)
        {
            for (int j = 0; j < dots - 1; j++)
            {
                Console.Write('.');
            }
            Console.Write("||");
            for (int j = 0; j < dots - 1; j++)
            {
                Console.Write('.');
            }
            Console.WriteLine();
        }
        for (int i = 0; i < k; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write('-');
            }
            Console.WriteLine();
        }
    }

    static void DrawWineGlass(int dots,int asterisks)
    {
        for (int i = 0; i < dots; i++)
        {
            Console.Write('.');
        }
        Console.Write('\\');
        for (int i = 0; i < asterisks; i++)
        {
            Console.Write('*');
        }
        Console.Write('/');
        for (int i = 0; i < dots; i++)
        {
            Console.Write('.');
        }
    }
}