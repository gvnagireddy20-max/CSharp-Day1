using System;
using System.Collections.Generic;

Console.WriteLine("===================================");
Console.WriteLine("Day 11 - Memory Collections & Type Safety");
Console.WriteLine("===================================");

Console.WriteLine("\nList<T> Example");

List<string> students = new List<string>();

students.Add("Reddy");
students.Add("Sai");
students.Add("Kiran");
students.Add("Ram");
students.Add("Ajay");

Console.WriteLine("\nStudents List");

foreach (string student in students)
{
    Console.WriteLine(student);
}

students.Remove("Sai");

Console.WriteLine("\nStudents List after removing Sai");
foreach (string student in students)
{
    Console.WriteLine(student);
}

Console.WriteLine($"\nTotal Students : {students.Count}");

Console.WriteLine("\nDictionary<TKey, TValue> Example");

Dictionary<int, string> studentDictionary = new Dictionary<int, string>();

studentDictionary.Add(101, "Reddy");
studentDictionary.Add(102, "Kiran");
studentDictionary.Add(103, "Ram");
studentDictionary.Add(104, "Ajay");

Console.WriteLine("\nStudent Dictionary");

foreach (KeyValuePair<int, string> student in studentDictionary)
{
    Console.WriteLine($"Roll No: {student.Key}, Name: {student.Value}");
}

Console.WriteLine("\nSearch Example");

int searchRollNo = 103;
if (studentDictionary.ContainsKey(searchRollNo))
{
    Console.WriteLine($"Roll No: {searchRollNo}, Name: {studentDictionary[searchRollNo]}");
}
else
{
    Console.WriteLine("Student not found.");
}

Console.WriteLine("\nQueue<T> Example");

Queue<string> studentQueue = new Queue<string>();

studentQueue.Enqueue("Reddy");
studentQueue.Enqueue("Sai");
studentQueue.Enqueue("Ram");


Console.WriteLine("\ncustomer Waiting:");

foreach (string customer in studentQueue)
{
    Console.WriteLine(studentQueue);
}

Console.WriteLine($"\nServing Customers : {studentQueue.Dequeue()}");
Console.WriteLine($"\nRemaining Customers : ");

foreach (string customer in studentQueue)
{
    Console.WriteLine(studentQueue);
}

Console.WriteLine("\nStack<T> Example");

Stack<string> browserHistory = new Stack<string>();
browserHistory.Push("Google");
browserHistory.Push("Youtube");
browserHistory.Push("GitHub");

Console.WriteLine("\nBrowser History:");

foreach (string page in browserHistory)
{
    Console.WriteLine(page);
}

Console.WriteLine($"\nBack Button Pressed : {browserHistory.Pop()}");

Console.WriteLine("\nCurrent Browser History:");

foreach (string page in browserHistory)
{
    Console.WriteLine(page);
}

Console.WriteLine("\nTime Complexity Example");

List<int> numbers = new List<int>();

numbers.Add(10);
numbers.Add(20);
numbers.Add(30);
numbers.Add(40);
numbers.Add(50);

int searchNumber = 40;

foreach (int number in numbers)
{
    if (number == searchNumber)
    {
        Console.WriteLine($"{searchNumber} Found in List");
        break;
    }
}

Console.WriteLine($"\nDictionary : {studentDictionary[101]}");
Console.WriteLine("\n======================================");
Console.WriteLine("Day 11 Completed Successfully!");
Console.WriteLine("======================================");
