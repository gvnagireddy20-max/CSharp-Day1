StudentService service = new StudentService();

Student student1 = new Student(1, "Reddy", "C#");
Student student2 = new Student(2, "Sai", "Java");

service.AddStudent(student1);
service.AddStudent(student2);

service.AddGrade(1, 85);
service.AddGrade(1, 90);
service.AddGrade(1, 95);

service.AddGrade(2, 70);
service.AddGrade(2, 75);
service.AddGrade(2, 80);

Console.WriteLine("Students:");

foreach (Student student in service.GetStudents())
{
    Console.WriteLine($"{student.Id} - {student.Name} - {student.Course}");

}

Console.WriteLine();
Console.WriteLine("Reddy's Grades:");

foreach (double grade in service.GetGrades(1))
{
    Console.WriteLine(grade);
}

GradeAnalytics analytics = new GradeAnalytics();
double average = analytics.GetAverage(service.GetGrades(1));

Console.WriteLine();
Console.WriteLine($"Reddy's Average: {average}");

Student topStudent = analytics.GetTopStudent(
    service.GetStudents(),
    service.GetAllGrades()
);

Console.WriteLine($"Top Student: {topStudent.Name}");
Console.WriteLine($"Top Student ID: {topStudent.Id}");

Console.WriteLine();

Console.WriteLine("Students with Average >= 80:");

List<Student> filteredStudents = analytics.GetStudentsAboveAverage(
    service.GetStudents(),
    service.GetAllGrades(),
    80
);

foreach (Student student in filteredStudents)
{
    Console.WriteLine($"{student.Name}");
}

Console.WriteLine();

Console.WriteLine("Students Sorted By Average:");

List<Student> sortedStudents = analytics.SortStudentsByAverage(
    service.GetStudents(),
    service.GetAllGrades()
);

foreach (Student student in sortedStudents)
{
    double studentAverage = analytics.GetAverage(
        service.GetGrades(student.Id)
    );

    Console.WriteLine($"{student.Name} - {studentAverage}");
}