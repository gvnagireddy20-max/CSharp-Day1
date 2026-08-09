public abstract class Person
{
    public int  Id { get; protected set;}
    public string Name { get; protected set;}
    public Person ( int id,string name)
    {
        if (id<=0)
        {
            throw new ArgumentException("Student ID must be greater than 0.");

        }
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException("Name cannot be empty.");
        }
        Id = id;
        Name = name;
    } 
}