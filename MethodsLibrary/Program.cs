using System;

class Program
{
    static void printBorder()
    {
        Console.WriteLine("================================");

    }
    static void SayHello(string name)
    {
        Console.WriteLine("Hello " + name);
    }
    static void StudentDetails(string name, int age)
    {
        Console.WriteLine("Name : " + name);
        Console.WriteLine("Age  : " + age);
    }
    static int Add(int a, int b)
    {
        return a + b;
    }
    static int Multiply(int a, int b)
    {
        return a * b;
    }
    static void Main()
    {
        printBorder();
        SayHello("Reddy");
        printBorder();
        StudentDetails("Reddy", 23);
        printBorder();
        int sum = Add(10,5);
        Console.WriteLine("Addition        : " + sum);
        int product = Multiply(4,5);
        Console.WriteLine("Multiplication  : " + product);
        printBorder();
    }
}
