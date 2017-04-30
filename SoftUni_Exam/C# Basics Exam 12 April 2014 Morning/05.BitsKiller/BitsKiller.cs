using System;

class BitsKiller
{
    static void Main()
    {
        int numOfElements = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
        byte[] userInput = new byte[numOfElements];
        int offset = 1;
        int count = 0;
        string result = string.Empty;
        string sum = string.Empty;
        for (int i = 0; i < numOfElements; i++)
        {
            userInput[i] = byte.Parse(Console.ReadLine());
            sum += Convert.ToString(userInput[i], 2).PadLeft(8, '0');
        }
        for (int i = 0; i < sum.Length; i++)
        {
            if (i - offset < 0 || (i - offset) % step > 0)
            {

                result += sum[i];
            }
            else
            {
                count++;
            }
        }
        result = result.PadRight(result.Length + count % 8, '0');
        string[] resOut = new string[result.Length / 8];
        for (int i = 0; i < resOut.Length; i++)
        {
            resOut[i] = result.Substring(i * 8, 8);
            Console.WriteLine(Convert.ToByte(resOut[i], 2));
        }
    }
}