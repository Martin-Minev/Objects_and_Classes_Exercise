using System;
using System.Collections.Generic;
using System.Linq;

namespace Order_by_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            List<Person> persons = new List<Person>();

            while ((input = Console.ReadLine()) != "End")
            {
                string[] tokens = input.Split();

                string name = tokens[0];
                int iD = int.Parse(tokens[1]);
                int age = int.Parse(tokens[2]);

                Person person = new Person()
                {
                    Name = name,
                    ID = iD,
                    Age = age,
                };
                persons.Add(person);
            }
            foreach (Person person in persons.OrderBy(p => p.Age))
            {
                Console.WriteLine($"{person.Name} with ID: {person.ID} is {person.Age} years old.");
            }
        }
        class Person
        {
            public string Name { get; set; }
            public int ID { get; set; }
            public int Age { get; set; }
        }
    }
}
