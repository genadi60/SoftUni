using System;
using System.Text;


class BitFlipper
{
    public static string ConvertToBinary(ulong value)
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
    static void Main()
    {
        ulong userInput = ulong.Parse(Console.ReadLine());
        string bin = ConvertToBinary(userInput).PadLeft(64,'0');
        char[] result = new char[64];
        for (int i = 0; i < bin.Length; i++)
        {
            if(i + 2 < bin.Length)
            {
                if (bin[i] == bin[i + 1] && bin[i + 1] == bin[i + 2])
                {
                    if (bin[i] != '1')
                    {
                        result[i] = result[i + 1] = result[i + 2] = '1';
                    }
                    else
                    {
                        result[i] = result[i + 1] = result[i + 2] = '0';
                    }
                    i += 2 ;
                }
                else
                {
                    result[i] = bin[i];
                }
            }
            else
            {
                result[i] = bin[i];
            }
        }
        string outBin = string.Empty;
        for (int i = 0; i < result.Length; i++)
        {
            outBin += result[i]; 
        }
        ulong outNum = Convert.ToUInt64(outBin, 2);
        Console.WriteLine(outNum);
    }
}