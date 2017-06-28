using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;


public class StudentGroups
{
    class Town
    {
        public string Name { get; set; }
        public int Seats { get; set; }
        public List<Student> Students { get; set; }
    }

    class Student
    {
        public string Name { get; set; }
        public string Mail { get; set; }
        public DateTime RegistrationDate { get; set; }
    }
    public static void Main()
    {
        var groupsByTown = new List<Dictionary<string, List<string>>>();
        var date = new DateTime();
        var towns = new List<Town>();
        var mails = new List<string>();
        var line = Console.ReadLine();
        while (!line.Equals("End"))
        {
            var town = new Town();
            var townSeats = line
                .Split("=>".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            var townName = townSeats[0].TrimEnd();
            var seatsNumber = 0;
            if (townSeats.Length > 1)
            {
                var seats = townSeats[1]
                    .Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                seatsNumber = int.Parse(seats[0]);
            }
            town.Name = townName;
            town.Seats = seatsNumber;
            line = Console.ReadLine();
            town.Students = new List<Student>();
            while (!line.Contains("=>"))
            {
                if (line.Equals("End"))
                {
                    break;
                }
                var student = new Student();
                var studentData = line
                    .Split('|')
                    .ToArray();
                var name = studentData[0].TrimEnd();
                var mail = studentData[1].TrimStart().TrimEnd();
                var dateByString = studentData[2].TrimStart().TrimEnd();
                date = DateTime.ParseExact(dateByString, "d-MMM-yyyy", CultureInfo.InvariantCulture);
                student.Name = name;
                student.Mail = mail;
                student.RegistrationDate = date;
                town.Students.Add(student);
                line = Console.ReadLine();
            }
            town.Students = town.Students.OrderBy(x => x.RegistrationDate).ThenBy(x => x.Name).ThenBy(x => x.Mail).ToList();
            towns.Add(town);
        }
        towns = towns.OrderBy(x => x.Name).ToList();
        foreach (var town in towns)
        {
            foreach (var st in town.Students)
            {
                mails.Add(st.Mail);
            }
            var count = town.Students.Count / town.Seats;
            if (town.Students.Count % town.Seats > 0)
            {
                count++;
            }
            for (int i = 0; i < count; i++)
            {
                var group = new Dictionary<string, List<string>>();
                if (!group.ContainsKey(town.Name))
                {
                    group[town.Name] = new List<string>();
                }
                group[town.Name].AddRange(mails.Skip(town.Seats * i).Take(town.Seats).ToList());
                groupsByTown.Add(group);
            }
            mails.Clear();
        }
        Console.WriteLine($"Created {groupsByTown.Count} groups in {towns.Count} towns:");
        foreach (var t in towns)
        {
           var townName = t.Name;
            foreach (var group in groupsByTown)
            {
                foreach (var kvp in group)
                {
                    var town = kvp.Key;
                    if (town.Equals(townName))
                    {
                        var mailsToPrint = String.Join(", ", kvp.Value);
                        Console.WriteLine($"{town} => {mailsToPrint}");
                    }
                }
            }
        }
    }
}