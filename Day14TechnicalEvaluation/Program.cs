
using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public string Name { get; set; } = "";
    public string Department { get; set; } = "";
    public List<double>?Marks { get; set; }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("===== Day 14 Architecture Challenge =====");

        Circle circle = new Circle();
        circle.Radius = 5;

        Rectangle rectangle = new Rectangle();
        rectangle.Length = 10;
        rectangle.Width = 5;

        Console.WriteLine($"Circle Area: {circle.Area}");
        Console.WriteLine($"Rectangle Area: {rectangle.Area}");

        Console.WriteLine("\n===== Day 14 LINQ Assessment =====");

        List<Student> students = new List<Student>
        {
            new Student
            {
                Name = "Ravi",
                Department = "CSE",
                Marks = new List<double> { 80, 90, 85 }
                
            },
             new Student
            {
                Name = "Priya",
                Department = "ECE",
                Marks = new List<double> { 70, 75, 80 }
                
            },
             new Student
            {
                Name = "Arun",
                Department = "CSE",
                Marks = new List<double> { 90, 95, 92 }
                
            },
             new Student
            {
                Name = "sneha",
                Department = "ECE",
                Marks = new List<double> { 85, 88, 90 }
                
            },
             new Student
            {
                Name = "Kiran",
                Department = "CSE",
                Marks = null
                
            }
            };

            var cseStudents = students
            .Where(s => s.Department == "CSE")
            .ToList();

            Console.WriteLine("\nCSE Students:");

            foreach (var student in cseStudents)
        {
            Console.WriteLine(student.Name);
        }

        var studentNames = students
            .Select(s => s.Name)
            .ToList();

            Console.WriteLine("\nStudent Names:");

            foreach (var name in studentNames)
        {
            Console.WriteLine(name);
        }

        var studentAverages = students
            .Select(s => new
            {
                s.Name,
                Average = s.Marks?.Average() ?? 0
            })
            .ToList();

            Console.WriteLine("\nStudent Averages:");

            foreach (var student in studentAverages)
        {
            Console.WriteLine($"{student.Name} : {student.Average:F2}");
        }

        var groups = students
            .GroupBy(s => s.Department);

            Console.WriteLine("\nStudents By Department:");

            foreach (var group in groups)
        {
            Console.WriteLine($"\nDepartment: {group.Key}");

            foreach (var student in group)
            {
                Console.WriteLine(student.Name);
            }
        }

        var topStudent = students
            .Where(s => s.Marks != null && s.Marks.Count > 0)
            .OrderByDescending(s => s.Marks!.Average())
            .FirstOrDefault();

            Console.WriteLine("\nTop Student:");

            if (topStudent != null)

        {
            Console.WriteLine($"{topStudent.Name} - {topStudent.Marks!.Average():F2}");
        }


        }
    }
