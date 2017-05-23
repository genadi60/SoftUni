using System;
using System.Collections.Generic;

class PrimesInGivenRange
{
    static void Main()
    {
        int startNum;
        int endNum;
        if (int.TryParse(Console.ReadLine(), out startNum));
        {
            if (int.TryParse(Console.ReadLine(), out endNum));
            {
                if (startNum >=0 && endNum >=0)
                {
                    List<int> primesInRange = new List<int>();
                    primesInRange = FindPrimesInRange(startNum, endNum);
                    Console.WriteLine(String.Join(", ", primesInRange));
                }
            } 
            
        } 
    }
    static List<int> FindPrimesInRange(int startNum, int endNum)
    {
        List<int> result = new List<int>();
        for (int i = startNum; i <= endNum; i++)
        {
            if (IsPrime(i))
            {
                result.Add(i);
            }
        }
        return result;
    }
    static bool IsPrime(int a)
    {
        bool result = true;
        int count = 0;

        if (a == 0 || a == 1)
        {
            count++;
        }

        for (int i = 2; i <= Math.Sqrt(a); i++)
        {
            if (a % i == 0)
            {
                count++;
            }
        }

        if (count != 0)
        {
            result = false;
        }

        return result;
    }
}