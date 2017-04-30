using System;
using System.Text;

class BitSifting
{
    static void Main()
    {
        ulong bitsToSieve = ulong.Parse(Console.ReadLine());
        int numberOfSieves = int.Parse(Console.ReadLine());
        ulong[] sieves = new ulong[numberOfSieves];
        for (int i = 0; i < numberOfSieves; i++)
        {
            sieves[i] = ulong.Parse(Console.ReadLine());
        }
        string bitsTS = ConvertToBinary(bitsToSieve).PadLeft(64, '0');
        char[] bits = new char[bitsTS.Length];
        int count = 0;
        for (int i = 0; i < bitsTS.Length; i++)
        {
            if (bitsTS[i] == '1')
            {
                count++;
            }
            bits[i] = bitsTS[i]; 
        }
        
        for (int i = 0; i < numberOfSieves; i++)
        {
            string siev = ConvertToBinary(sieves[i]).PadLeft(64, '0');
            for (int j = 0; j < bits.Length; j++)
            {
                
                if(bits[j] == '1' && siev[j] == '1')
                {
                    bits[j] = '0';
                    count--; 
                }
            }
        }
        Console.WriteLine(count);
    }
    static string ConvertToBinary(ulong value)
    {
        if (value == 0) return "0";
        StringBuilder b = new StringBuilder();
        while (value != 0)
        {
            b.Insert(0, ((value & 1) == 1) ? '1' : '0');
            value >>= 1;
        }
        return b.ToString();
    }
}