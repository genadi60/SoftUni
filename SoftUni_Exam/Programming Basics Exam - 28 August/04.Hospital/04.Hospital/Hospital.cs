using System;

class Hospital
{
    static void Main()
    {
        int period = int.Parse(Console.ReadLine());
        int[] patients = new int[period];
        int doctors = 7;
        int treated = 0;
        int untreated = 0;
        int counter = 0;
        for (int i = 0; i < period; i++)
        {
            counter++;
            if (counter == 3)
            {
                if (untreated > treated)
                {
                    doctors++;
                }
                counter = 0;
            }

            patients[i] = int.Parse(Console.ReadLine());
            
            if (patients[i] > doctors)
            {
                untreated += patients[i] - doctors;
                treated += doctors;
            }
            else
            {
                treated += patients[i];
            }
            
        }

        Console.WriteLine("Treated patients: {0}.", treated);
        Console.WriteLine("Untreated patients: {0}.", untreated);
    }
}