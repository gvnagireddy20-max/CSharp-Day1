using System;

Console.WriteLine("===== Day 10: Designing Contracts =====");
Console.WriteLine();

Notification email = new EmailNotification();
email.Send();
email.displayStatus();

Console.WriteLine();

Notification sms = new SmsNotification();
sms.Send();
sms.displayStatus();

Console.WriteLine();

ILogger logger = new ConsoleLogger();
NotificationService service = new NotificationService(logger);
service.Save("Email Notification Saved");

Console.WriteLine();

ILogger fakeLogger = new FakeLogger();
NotificationService fakeService = new NotificationService(fakeLogger);
fakeService.Save("Testing Notification");

Console.WriteLine();

Machine machine = new Machine();

IPrinter printer = machine;   
printer.Print();

IScanner scanner = machine;
scanner.Print();

Console.WriteLine("Day 10 Concepts Successfully Completed!");


abstract class Notification
{
    public string  Title { get; set;}
    public Notification(string title)
    {
        Title = title;
    }

    public abstract void Send();

    public virtual void displayStatus()
    {
        Console.WriteLine("Notification Delivered");

    }
}

class EmailNotification : Notification
{
    public EmailNotification() : base("Email Notification")
    {
    }

    public override void Send()
    {
        Console.WriteLine($"Email Notification: {Title}");
    }
}

class SmsNotification : Notification
{
    public SmsNotification() : base("SMS Notification")
    {
    }

    public override void Send()
    {
        Console.WriteLine($"SMS Notification: {Title}");
    }
}

interface ILogger
{
    void Log(string message);
}

class ConsoleLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine($"Log: {message}");
    }
}

class FakeLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine($"Fake Log: {message}");
    }
}

class NotificationService
{
    private ILogger _logger;

    public NotificationService(ILogger logger)
    {
        _logger = logger;
    }

    public void Save(string message)
    {
        _logger.Log(message);
    }
}

interface IPrinter
{
    void Print();
}

interface IScanner
{
    void Print();
}

class Machine : IPrinter, IScanner
{
    void IPrinter.Print()
    {
        Console.WriteLine("Printing from Printer");
    }

    void IScanner.Print()
    {
        Console.WriteLine("Printing from Scanner");
    }
}
