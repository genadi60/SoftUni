using System;
using System.Text;

public class KarateStrings
{
    public static void Main()
    {
        StringBuilder line = new StringBuilder();
        line.AppendLine(Console.ReadLine());
        var strength = 0;
        for (int i = 0; i < line.Length - 1; i++)
        {
            if (line[i].Equals('>') && Char.IsDigit(line[i + 1]))
            {
                strength += int.Parse(line[i + 1].ToString());
                line.Remove((i + 1), 1);
                strength--;
                while (line.Length >= (i + 1) && strength > 0 && !line[i + 1].Equals('>'))
                {
                    line.Remove((i + 1), 1);
                    strength--;
                }
                i--;
            }
        }
        Console.WriteLine(line);
    }
}