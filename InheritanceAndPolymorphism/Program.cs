using System;

class Vehicle
{
    public string Brand;

    public Vehicle(string brand)
    {
        Brand = brand;
        Console.WriteLine($"Vehicle brand: {Brand}");
    }

    public virtual void Start()
    {
        Console.WriteLine("Vehicle is starting.");
    }

    public virtual void Stop()
    {
        Console.WriteLine("Vehicle is stopping.");
    }

}

class Engine
{
    public void startEngine()
    {
        Console.WriteLine("Engine is starting.");
    }
}

class Car : Vehicle
{
    private Engine engine = new Engine();

    public Car(string brand) : base(brand)
    {
       
    }

    public override void Start()
    {
        engine.startEngine();
        Console.WriteLine("Car is starting.");
    }

}
    
    class Bike : Vehicle
    {
        public Bike(string brand) : base(brand)
        {
        }

        public override void Start()
        {
            Console.WriteLine("Bike is starting.");
        }
    }

    class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }
    }

    sealed class Utility
    {
        public void Display()
        {
            Console.WriteLine("Utility class.");
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            
            
        Console.WriteLine("===================");
        Console.WriteLine(" vehicle Management System");
        Console.WriteLine("===================");
        
        Vehicle vehicle = new Car("Toyota");
            vehicle.Start();
            vehicle.Stop();
            
            Console.WriteLine();

           Vehicle vehicle2 = new Bike("Honda");
           vehicle2.Start();
           vehicle2.Stop();

           Console.WriteLine();

            Calculator calculator = new Calculator();
            Console.WriteLine("Addition of 10 + 20 = " + calculator.Add(10, 20));
             Console.WriteLine("Addition of 10 + 20 + 30 = " + calculator.Add(10, 20, 30));

        Console.WriteLine();

            Utility Util = new Utility();
            Util.Display();

            Console.WriteLine();

        Console.WriteLine("Day 9 Concepts Successfully Completed!");
        }
    }