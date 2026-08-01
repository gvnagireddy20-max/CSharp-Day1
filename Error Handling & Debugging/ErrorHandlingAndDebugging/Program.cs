using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("====== Day 5 - Error Handling & Debugging =====");
        
        Console.WriteLine("\n1. Divide by Zero Exception");
        DivideByZeroDemo();
        Console.WriteLine("\n2. Null Reference Exception");
        NullReferenceDemo();
        Console.WriteLine("\n3. Multiple Catch Blocks");
        MultipleCatchDemo();
        Console.WriteLine("\n4. Finally Block");
        FinallyDemo();
        Console.WriteLine("\n5. Program Completed");
    }
    static void DivideByZeroDemo()
    {
        try
        {
        int number1 = 20;
        int number2 = 0;
        int result = number1 / number2;
        Console.WriteLine(result);
    }
    catch(Exception ex)
    {
        Console.WriteLine("Exception Type : ");
        Console.WriteLine(ex.GetType().Name);

        Console.WriteLine();

        Console.WriteLine("Error Message : ");
        Console.WriteLine(ex.Message);

        Console.WriteLine();

        Console.WriteLine("Stack Trace : ");
        Console.WriteLine(ex.StackTrace);
    }
    }

    static void NullReferenceDemo()
{
    try
    {
        string name = null;

        Console.WriteLine(name.Length);
    }
    catch (NullReferenceException ex)
    {
        Console.WriteLine("Exception Type : " + ex.GetType().Name);
        Console.WriteLine("Message : " + ex.Message);
    }
}
    static void MultipleCatchDemo()
    {
        try
        {
            Console.Write("Enter First Number: ");
            int number1 = int.Parse(Console.ReadLine());

            Console.Write("Enter Second Number: ");
            int number2 = int.Parse(Console.ReadLine());

            int result = number1 / number2;

            Console.WriteLine("Result = " + result);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("You cannot divide by zero.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Please enter valid numbers.");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    static void FinallyDemo()
    {
        try
        {
            Console.WriteLine("Inside Try");

            int number1 = 20;
            int number2 = 5;

            int result = number1 / number2;

            Console.WriteLine("Result = " + result);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("Inside Finally");
        }

        Console.WriteLine("Program Ended");
    }
}