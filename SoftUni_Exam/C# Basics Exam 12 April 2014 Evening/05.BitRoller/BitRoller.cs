using System;

class BitRoller
{
    static void Main()
    {
        uint userInput = uint.Parse(Console.ReadLine());
        int freezePozition = int.Parse(Console.ReadLine());

        int rolTimes = int.Parse(Console.ReadLine());

        string binLong = Convert.ToString(userInput, 2).PadLeft(19, '0');

        string right = binLong.Substring(binLong.Length - freezePozition, freezePozition);

        string left1 = binLong.Substring(0, binLong.Length - right.Length);
        string freeze = left1.Substring(left1.Length - 1, 1);
        string left = left1.Substring(0, left1.Length - 1);
        string sum = left + right;
        int rotateResult = BitRotate(sum, rolTimes);
        string rotate = Convert.ToString(rotateResult, 2).PadLeft(18, '0');

        string leftResult = rotate.Substring(0, left.Length);
        string rightResult = rotate.Substring(left.Length, right.Length);
        string result = leftResult + freeze + rightResult;
        Console.WriteLine(Convert.ToUInt32(result, 2));
    }

    static int BitRotate(string rot, int rotTimes)
    {
        int moov = rot.Length -1;
        int num = Convert.ToInt32(rot, 2);
        for (int i = 0; i < rotTimes; i++)
        {
            int mask = num % 2;
            num = num >> 1;
            if (mask == 1)
            {
                int maskNum = 1 << moov;
                num = num | maskNum;
            }
        }

        return num;
    }
}