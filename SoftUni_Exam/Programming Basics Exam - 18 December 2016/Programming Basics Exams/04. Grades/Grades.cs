using System;
using System.Collections.Generic;

class Grades
{
    static void Main()
    {
        int studentNumbers = int.Parse(Console.ReadLine());
        List<float> top = new List<float>();
        List<float> four = new List<float>();
        List<float> three = new List<float>();
        List<float> fail = new List<float>();
        float sum = 0.0f;
        for (int i = 0; i < studentNumbers; i++)
        {
            float grade = float.Parse(Console.ReadLine());
            sum += grade;
            if(grade < 3.00f)
            {
                fail.Add(grade);
            }
            else if (grade <= 3.99f)
            {
                three.Add(grade);
            }
            else if (grade <= 4.99f)
            {
                four.Add(grade);
            }
            else
            {
                top.Add(grade);
            }
        }
        float average = sum / studentNumbers;
        float topPercent = top.Count * 100.00f / studentNumbers;
        float fourPercent = four.Count * 100.00f / studentNumbers;
        float threePercent = three.Count * 100.00f / studentNumbers;
        float failPercent = fail.Count * 100.00f / studentNumbers;
        Console.WriteLine("Top students: {0:F2}%", topPercent);
        Console.WriteLine("Between 4.00 and 4.99: {0:F2}%", fourPercent);
        Console.WriteLine("Between 3.00 and 3.99: {0:F2}%", threePercent);
        Console.WriteLine("Fail: {0:F2}%", failPercent);
        Console.WriteLine("Average: {0:F2}", average);
    }
}

