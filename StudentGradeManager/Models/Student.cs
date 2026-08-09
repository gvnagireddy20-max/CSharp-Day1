public class Student : Person
{
    public string Course { get; private set; }
    public Student(int id, string name,string course)
    : base (id, name)
    {
        if (string.IsNullOrWhiteSpace(course))
        {
            throw new ArgumentException("Course cannot be empty.");

        }
        Course = course;
    }
    }

