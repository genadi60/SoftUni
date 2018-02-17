using System;
using System.Collections.Generic;
using System.Linq;

public class OrderByAge
{
    class Person
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }
    }
    public static void Main()
    {
        var persons = new List<Person>();
        while (true)
        {
            var line = Console.ReadLine();
            if (line.Equals("End"))
            {
                break;
            }
            var personData = line
                .Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            var personName = personData[0];
            var personID = personData[1];
            var personAge = int.Parse(personData[2]);
            var person = new Person();
            person.Name = personName;
            person.ID = personID;
            person.Age = personAge;
            persons.Add(person);
        }
        persons = persons.OrderBy(x => x.Age).ToList();
        foreach (var person in persons)
        {
            Console.WriteLine($"{person.Name} with ID: {person.ID} is {person.Age} years old.");
        }
    }
}