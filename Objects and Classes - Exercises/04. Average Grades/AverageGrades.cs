using System;
using System.Collections.Generic;
using System.Linq;

public class AverageGrades
{
    class Student
    {
        public string Name { get; set; }
        public double[] Grades { get; set; }
        public double AverageGrade { get; set; }
    } 
    public static void Main()
    {
        var numberOfStudents = int.Parse(Console.ReadLine());
        var students = new List<string[]>();
        for (int i = 0; i < numberOfStudents; i++)
        {
            var input = Console.ReadLine()
                .Split()
                .ToArray();
            students.Add(input);
        }
        var studentsClass = new List<Student>();
        
        foreach (var item in students)
        {
            var student = new Student();
            var average = 0.0;
            student.Name = item[0];
            student.Grades = new double[item.Length - 1];
            for (int i = 1; i < item.Length; i++)
            {
                var grade = double.Parse(item[i]);
                student.Grades[i - 1] = grade;
                average += grade;
            }
            student.AverageGrade = average / (item.Length - 1);
            studentsClass.Add(student);
        }
        foreach (var st in studentsClass.OrderBy(x => x.Name).ThenByDescending(x => x.AverageGrade).Where(x => x.AverageGrade >= 5.00))
        {
            var name = st.Name;
            var average = st.AverageGrade;
            Console.WriteLine($"{name} -> {average:F2}");
        }
    }
}