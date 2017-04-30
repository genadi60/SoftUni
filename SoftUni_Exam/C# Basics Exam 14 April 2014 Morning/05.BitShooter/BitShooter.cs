using System;
using System.Text;

class BitShooter
{
    static void Main()
    {
        ulong userInput = ulong.Parse(Console.ReadLine());
        string[] firstShoot = Console.ReadLine().Split(' ');
        string[] secondShoot = Console.ReadLine().Split(' ');
        string[] thirdShoot = Console.ReadLine().Split(' ');
        ulong shootedNumber = 0UL;
        string bin = ConvertToBinary(userInput).PadLeft(64, '0');
        shootedNumber = Shootting(userInput, firstShoot);
        bin = ConvertToBinary(shootedNumber).PadLeft(64, '0');
        shootedNumber = Shootting(shootedNumber, secondShoot);
        bin = ConvertToBinary(shootedNumber).PadLeft(64, '0');
        shootedNumber = Shootting(shootedNumber, thirdShoot);
        bin = ConvertToBinary(shootedNumber).PadLeft(64,'0');
        string firstHalf = bin.Substring(0, 32);
        string secondHalf = bin.Substring(32, 32);
        int counter1First = 0;
        int counter1Second = 0;
        foreach(char item in firstHalf)
        {
            if(item == '1')
            {
                counter1First++;
            }
        }
        foreach (char item in secondHalf)
        {
            if (item == '1')
            {
                counter1Second++;
            }
        }
        Console.WriteLine("left: {0}", counter1First);
        Console.WriteLine("right: {0}", counter1Second);
    }

    static int[] CenterAndSizeFind(string[] shoot)
    {
        int[] array = new int[2];
        for (int i = 0; i < shoot.Length; i++)
        {
            array[i] = int.Parse(shoot[i]);
        }
        return array;
    }

    static ulong Shootting(ulong a, string[] shoot)
    {
        ulong result = 0UL;
        int[] coord = CenterAndSizeFind(shoot);
        ulong mask = 0UL;
        for (int i = 0; i < coord[1]; i++)
        {
            mask += (ulong)Math.Pow(2, i);
        }
        int mooving = coord[0] - coord[1] / 2;
        if(mooving < 0)
        {
            mask = mask >> -mooving;
        }
        else
        {
            mask = mask << mooving;
        }
        result = a & ~mask;
        return result;
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