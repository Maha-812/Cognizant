using System;

interface IPaymentProcessor
{
    void ProcessPayment();
}

class OldPaymentGateway
{
    public void MakePayment()
    {
        Console.WriteLine("Payment processed using old gateway");
    }
}

class PaymentAdapter : IPaymentProcessor
{
    private OldPaymentGateway gateway;

    public PaymentAdapter()
    {
        gateway = new OldPaymentGateway();
    }

    public void ProcessPayment()
    {
        gateway.MakePayment();
    }
}

class Program
{
    static void Main()
    {
        IPaymentProcessor processor = new PaymentAdapter();
        processor.ProcessPayment();
    }
}