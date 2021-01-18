using System;
using System.Linq;
using System.Collections.Generic;


namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Students> students = new List<Students>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ");
                string firstName = input[0];
                string lastName = input[1];
                double grade = double.Parse(input[2]);

                Students student = new Students(firstName, lastName, grade);
                students.Add(student);
            }
            students = students.OrderByDescending(x => x.Grade).ToList();
            foreach (Students currentStudent in students)
            {
                Console.WriteLine(currentStudent);
            }
           
        }
    }
    class Students
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }

        public Students(string firstName, string lastName, double grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }
        public override string ToString()
        {
            return $"{FirstName} {LastName}: {Grade:F2}";
        }
    }
}
