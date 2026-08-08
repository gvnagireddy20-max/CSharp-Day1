using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Course { get; set; }
    public int Marks { get; set; }

    public Student(string name, int age, string course, int marks)
    {
        Name=name;
        Age =age;
        Course=course;
        Marks=marks;
        }
}
class Program
{
    static void Main()
    {
        List<Student> students = CreateStudents();

        Console.WriteLine("=============");
        Console.WriteLine("  LINQ AND CLEAN CODE ");
        Console.WriteLine("=============");

        DisplayAllStudents(students);
        DisplayAdultStudents(students);
        DisplayStudentName(students);
        DisplayStudentsByName(students);
        FindFirstTopStudent(students);
        GroupStudentsByCourse(students);
        DemonstrateDeferredExecution(students);
        DisplayEligibleStudents(students);

        Console.WriteLine("\nDay 12 Concepts Successfully Completed");
        
        }
        static List<Student> CreateStudents()
    {
        return new List<Student>
        {
            new Student("Reddy", 23, "c#", 84),
            new Student("Sai", 17, "Java", 72),
            new Student("Kiran", 25, "c#", 90),
            new Student("Ram", 21, "Java", 65),
            new Student("Ajay", 19, "Python", 78)
        };
    }

    static void DisplayAllStudents(List<Student> students)
    {
        Console.WriteLine("\nAll Students");

        foreach (Student student in students)
        {
            Console.WriteLine($"Name: {student.Name}, Age: {student.Age}, Course: {student.Course}, Marks: {student.Marks}");

        }
    }

        static void DisplayAdultStudents(List<Student> students)
    {
        Console.WriteLine("\nStudents Age 18 and Above");
        var adults = students
        .Where(students => students.Age >=18);

        foreach (Student student in adults)
        {
            Console.WriteLine(student.Name);
        }


    }
    static void DisplayStudentName(List<Student> students)
    {
        Console.WriteLine("\nStudent Names");

        var names = students
        .Select(student => student.Name);

        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
    }
    static void DisplayStudentsByName(List<Student> students)
    {
        Console.WriteLine("\nStudents Stored By Name");

        var sortedStudents = students
        .OrderBy(student => student.Name);

        foreach (Student student in sortedStudents)
        {
            Console.WriteLine(student.Name);
        }

    }
    static void FindFirstTopStudent(List<Student> students)
    {
        Console.WriteLine("\nFirst Student With Marks 80 Or Above");

        Student? student = students
            .FirstOrDefault(student => student.Marks >= 80);

            if (student == null)
        {
            Console.WriteLine("No Student Found.");
            return;

        }
        Console.WriteLine(
            $"{student.Name} - {student.Marks}");
    }

    static void GroupStudentsByCourse(List<Student> students)
    {
        Console.WriteLine("\nStudents Grouped By Course");

        var groups = students
            .GroupBy(student => student.Course);

        foreach (var group in groups)
        {
            Console.WriteLine($"\nCourse: {group.Key}");

            foreach (Student student in group)
            {
                Console.WriteLine(student.Name);
            }
        }
    }

    static void DemonstrateDeferredExecution(List<Student> students)
    {
        Console.WriteLine("\nDeferred Execution Example");

        var adults = students
            .Where(student => student.Age >= 18);

        students.Add(new Student("Arun", 22, "C#", 88));

        foreach (Student student in adults)
        {
            Console.WriteLine(student.Name);
        }
    }

    static void DisplayEligibleStudents(List<Student> students)
    {
        Console.WriteLine("\nEligible Students");

        var eligibleStudents = students
            .Where(IsEligibleStudent)
            .OrderBy(student => student.Name)
            .Select(student => student.Name);

        foreach (string name in eligibleStudents)
        {
            Console.WriteLine(name);
        }
    }

    static bool IsEligibleStudent(Student student)
    {
        if (student == null)
        {
            return false;
        }

        if (student.Age < 18)
        {
            return false;
        }

        if (student.Marks < 60)
        {
            return false;
        }

        return true;
    }
}
    