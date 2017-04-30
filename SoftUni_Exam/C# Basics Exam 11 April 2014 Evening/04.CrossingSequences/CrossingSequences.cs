using System;

class CrossingSequences
{
    static void Main()
    {
        int range = 1000000;
        int[] trib = new int[3];
        int tribSum = 0;
        for (int i = 0; i < trib.Length; i++)
        {
            trib[i] = int.Parse(Console.ReadLine());
        }
        int[] spiral = new int[3];
        for (int i = 0; i < spiral.Length -1; i++)
        {
            spiral[i] = int.Parse(Console.ReadLine());
        }
        spiral[2] = 0;
        for (int i = 0; i < trib.Length; i++)
        {
            if (trib[i] == spiral[0])
            {
                trib[0] = -1;
            }
        }
        int step = spiral[1];
        while (trib[0] > 0)
        {
            trib = TribControl(trib, spiral, range, step, tribSum);
        }
        if (trib[0] == -1)
        {
            Console.WriteLine(spiral[0]);
        }
        if (trib[0] == 0)
        {
            Console.WriteLine("No");
        }
    }
        
    static int[] TribControl(int[] trib, int[] spiral, int range, int step, int tribSum)
    {
        if(spiral[0] < trib[0] || spiral[0] < trib[1] || spiral[0] < trib[2] )
        {
            Spiral(spiral, step);
        }
        else if(spiral[0] > trib[2])
        {
            Tribunachi(trib, tribSum);
        }
        for (int i = 0; i < trib.Length; i++)
        {
            if (trib[i] == spiral[0])
            {
                trib[0] = -1;
            }
            else if (trib[2] > range || spiral[0] > range)
            {
                trib[0] = 0;
                return trib;
            }
        }
        return trib;
    }

    static int[] Spiral(int[] spiral, int step)
    {
        if (spiral[2] == 2)
        {
            spiral[1] += step;
            spiral[2] = 0;
        }
        spiral[2]++;
        spiral[0] += spiral[1];
        return spiral;
    }

    static int[] Tribunachi(int[] trib, int tribSum)
    {
        for (int i = 0; i < trib.Length; i++)
        {
            tribSum += trib[i];
        }
        trib[0] = trib[1];
        trib[1] = trib[2];
        trib[2] = tribSum;
        tribSum = 0;
        return trib;
    }
}