using System;
using System.Collections.Generic;
using System.Linq;

public class StudentService
{
    private readonly List<Student> students = new();

    private readonly Dictionary<int, List<double>> grades = new();
    public void AddStudent(Student student)
    {
        if (students.Any(s => s.Id == student.Id))
        {
            throw new ArgumentException("Student ID already exists.");

    }

    students.Add(student);
    grades[student.Id] = new List<double>();

}

public List<Student> GetStudents()
{
    return students;
}

public void AddGrade(int studentId, double grade)
{
    if (grade < 0 || grade > 100)
    {
        throw new ArgumentException("Grade must be between 0 and 100.");

    }

    if (!grades.ContainsKey(studentId))
    {
        throw new ArgumentException("Student not found.");
    }

    grades[studentId].Add(grade);

}

public List<double> GetGrades(int studentId)
{
    if (!grades.ContainsKey(studentId))
    {
        throw new ArgumentException("Student not found.");
    }
    return grades[studentId];
    }
    public Dictionary<int, List<double>> GetAllGrades()
    {
        return grades;
    }
}