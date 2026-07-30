using System;
class Program
{
    static void SayHello(String name,int age)
    {
        Console.WriteLine("Name :" + name);
        Console.WriteLine("Age  :" + age);
    }
    static void Main()
    {
        Console.WriteLine("Program Started");
        SayHello("Reddy", 23);
        Console.WriteLine("Program Ended");

    }
}
