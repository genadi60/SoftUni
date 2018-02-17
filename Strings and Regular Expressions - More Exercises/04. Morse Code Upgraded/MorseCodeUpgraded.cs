using System;
using System.Text;

public class MorseCodeUpgraded
{
    public static void Main()
    {
        var sum = 0;
        var count = 0;
        StringBuilder line = new StringBuilder();
        StringBuilder message = new StringBuilder();
        line.AppendLine(Console.ReadLine());
        for (int i = 0; i < line.Length; i++)
        {
            while (line[i] == '0' || line[i] == '1')
            {
                while (line[i] == '0')
                {
                    count++;
                    sum += 3;
                    line.Remove(i, 1);
                }
                if (count > 1)
                {
                    sum += count;
                }
                count = 0;
                while (line[i] == '1')
                {
                    count++;
                    sum += 5;
                    line.Remove(i, 1);
                }
                if (count > 1)
                {
                    sum += count;
                }
                count = 0;
            }
            message.Append((char) sum);
            sum = 0;
        }
        Console.WriteLine(message);
    }
}