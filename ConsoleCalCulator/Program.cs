using System;
using System.Collections.Generic;

class Program
{
    static List<string> history = new List<string>();
    static void Main()
    {
        char continueChoice ='n';

        do
        {
            
        try
        {
        Console.WriteLine("==========================");
        Console.WriteLine("    Console Calculator");
        Console.WriteLine("==========================");

        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");

        Console.Write("\nChoose an operation (1-4): ");
        int choice = Convert.ToInt32(Console.ReadLine());


        Console.Write("\n Enter first number: ");
        double number1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter second number: ");
        double number2 = Convert.ToDouble(Console.ReadLine());

        switch (choice)
        {
            case 1:
            {
            double resultAdd = Add(number1, number2);
            Console.WriteLine($"Result = {resultAdd}");
            history.Add($"{number1} + {number2} = {resultAdd}");
            break;
            }
            case 2:
            {
            double resultSub = Subtract(number1, number2);
            Console.WriteLine($"Result = {resultSub}");
            history.Add($"{number1} - {number2} = {resultSub}");
            break;
            }
            case 3:
            {
                double resultMul = Multiply(number1, number2);
            Console.WriteLine($"Result = {resultMul}");
            history.Add($"{number1} * {number2} = {resultMul}");
            break;
            }
            case 4:
            {
                double resultDiv = Divide(number1, number2);
            Console.WriteLine($"Result = {resultDiv}");
            history.Add($"{number1} / {number2} = {resultDiv}");
            break;
            }

            default:
            Console.WriteLine("Invalid Choice");
            break;
        }

        
        if (history.Count > 5)
        {
            history.RemoveAt(0);
        }
        Console.WriteLine("\nCalculation History:");
        foreach (var entry in history)
        {
            Console.WriteLine(entry);

        }

        Console.Write("\nDo you want to perform another calculation? (y/n): ");
        continueChoice = Convert.ToChar(Console.ReadLine().ToLower());
        }

        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
        }

        while (continueChoice == 'y');
        }




        static double Add(double a, double b)
        {
            return a + b;
        }
        static double Subtract(double a, double b)
        {
            return a - b;
        }
        static double Multiply(double a, double b)
        {
            return a * b;
        }
        static double Divide(double a, double b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException();  
        }
        return a / b;
    }
}
    

