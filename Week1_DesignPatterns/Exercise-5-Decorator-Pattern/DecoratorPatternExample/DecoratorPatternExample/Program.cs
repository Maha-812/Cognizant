using System;

interface INotifier
{
    void Send();
}

class EmailNotifier : INotifier
{
    public void Send()
    {
        Console.WriteLine("Sending Email Notification");
    }
}

class SMSDecorator : INotifier
{
    private INotifier notifier;

    public SMSDecorator(INotifier notifier)
    {
        this.notifier = notifier;
    }

    public void Send()
    {
        notifier.Send();
        Console.WriteLine("Sending SMS Notification");
    }
}

class Program
{
    static void Main()
    {
        INotifier notifier = new SMSDecorator(new EmailNotifier());
        notifier.Send();
    }
}