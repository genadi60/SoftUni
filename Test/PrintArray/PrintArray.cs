using System;

class PrintArray
{
    static void Main()
    {
        int[] x = new int[3] { 1, 2, 3 };

        Console.Write('[');
        for (int i = 0; i < x.Length; i++)
        {
            Console.Write(x[i]);
            if (i < x.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.Write(']');
        Console.WriteLine();
    }
}