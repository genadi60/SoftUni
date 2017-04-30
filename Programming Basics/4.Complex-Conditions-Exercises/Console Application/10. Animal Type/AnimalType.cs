using System;

class AnimalType
{
    static void Main()
    {
        string animal = Console.ReadLine().ToLower();
        string typeOfAnimal = string.Empty;
        switch (animal)
        {
            case "dog":
                typeOfAnimal = "mammal";
                break;
            case "crocodile":
            case "tortoise":
            case "snake":
                typeOfAnimal = "reptile";
                break;
            default:
                typeOfAnimal = "unknown";
                break;
        }
        Console.WriteLine(typeOfAnimal);
    }
}