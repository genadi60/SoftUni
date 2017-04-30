using System;

class NumberPyramid
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                k++;
                Console.Write(k);
                if(k == n)
                {
                    break;
                }
                Console.Write(" ");
            }
            Console.WriteLine();
            if (k == n)
            {
                break;
            }
        }
    }
}