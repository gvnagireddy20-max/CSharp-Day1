Student student = new Student("Reddy", 23, "C#");

student.Display();

Console.WriteLine();
Console.WriteLine("Updating Age to 25...");
student.UpdateAge(25);
student.Display();

Console.WriteLine();
Console.WriteLine("Trying to Update Age to -10...");
student.UpdateAge(-10);
student.Display();

public class Student
{
    private int age;

    public string Name { get; private set; }

    public string Course { get; private set; }

    public int Age

    {
        get 
        {
             return age; 
             }
        private set
        {
            if (value >= 0)
            {
                age = value;
            }
        }
    }   

    static Student()
    {
        Console.WriteLine("Student Class Loaded");
    }

        public Student(string name, int age, string course)
    {
        Name = name;
        Age = age;
        Course = course;
        
    }
    public void UpdateAge(int newAge)
    {
        Age = newAge;
        
    }
    public void Display()
    {

    Console.WriteLine();
    Console.WriteLine("Student Details");
    Console.WriteLine("----------------");
    Console.WriteLine("Name: " + Name);
    Console.WriteLine("Age: " + Age);
    Console.WriteLine("Course: " + Course);

}
}

            
            