using System;

class DayOfWeek
{
    static void Main()
    {
        string[] daysOfWeek = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        int index = int.Parse(Console.ReadLine());
        if(index >= 1 && index <= 7)
        {
            Console.WriteLine(daysOfWeek[index - 1]);
        }
        else
        {
            Console.WriteLine("Error");
        }
    }
}