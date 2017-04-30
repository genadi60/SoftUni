using System;

class StudentCables
{
    static void Main()
    {
        int cableStudentLength = 504;
        int join = 3;
        int trowCable = 20;
        int cableLength = 0;
        int nuberOfPieces = 0;

        int numberOfCables = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < numberOfCables; i++)
        {
            int inputCable = int.Parse(Console.ReadLine());
            string measure = Console.ReadLine();
            if(measure == "meters")
            {
                inputCable *= 100;
            }
            if(inputCable >= trowCable)
            {
                nuberOfPieces++; 
                cableLength += inputCable;
            }
        }
        cableLength = cableLength - (nuberOfPieces -1) * join;
        int numberOfCableStudent = cableLength / cableStudentLength;
        int remainingCable = cableLength - numberOfCableStudent * cableStudentLength;

        Console.WriteLine(numberOfCableStudent);
        Console.WriteLine(remainingCable);
    }
}