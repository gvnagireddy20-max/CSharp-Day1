using System.Collections.Generic;
using System.Linq;

public class GradeAnalytics
{
    public double GetAverage(List<double> grades)
    {
        return grades.Average();
    }

    public Student GetTopStudent(
        List<Student> students,
        Dictionary<int, List<double>> grades)
    {
        Student topStudent = students[0];
        double topAverage = GetAverage(grades[topStudent.Id]);

        foreach (Student student in students)
        {
            double average = GetAverage(grades[student.Id]);
            
            if (average > topAverage)
            {
                topAverage = average;
                topStudent = student;
            }
        }

        return topStudent;
    }

    public List<Student> GetStudentsAboveAverage(
        List<Student> students,
        Dictionary<int, List<double>> grades,
        double minimumAverage)
    {
        return students
            .Where(student => GetAverage(grades[student.Id]) >= minimumAverage)
            .ToList();
    }

    public List<Student> SortStudentsByAverage(
        List<Student> students,
        Dictionary<int, List<double>> grades)
    {
        return students
            .OrderByDescending(student => GetAverage(grades[student.Id]))
            .ToList();
    }
}