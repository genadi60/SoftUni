using System;

class Elevator
{
    static void Main()
    {
        int persons = int.Parse(Console.ReadLine());
        int elevatorCapacity = int.Parse(Console.ReadLine());
        int courses = persons / elevatorCapacity;
        if (persons % elevatorCapacity != 0)
        {
            courses++;
        }
        Console.WriteLine(courses);
    }
}