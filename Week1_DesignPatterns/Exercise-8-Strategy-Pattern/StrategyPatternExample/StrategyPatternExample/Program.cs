using System;

interface IPaymentStrategy
{
    void Pay(double amount);
}

class CreditCardPayment : IPaymentStrategy
{
    public void Pay(double amount)
    {
        Console.WriteLine($"Paid Rs.{amount} using Credit Card");
    }
}

class PayPalPayment : IPaymentStrategy
{
    public void Pay(double amount)
    {
        Console.WriteLine($"Paid Rs.{amount} using PayPal");
    }
}

class PaymentContext
{
    private IPaymentStrategy strategy;

    public PaymentContext(IPaymentStrategy strategy)
    {
        this.strategy = strategy;
    }

    public void ExecutePayment(double amount)
    {
        strategy.Pay(amount);
    }
}

class Program
{
    static void Main()
    {
        PaymentContext payment1 =
            new PaymentContext(new CreditCardPayment());

        payment1.ExecutePayment(5000);

        PaymentContext payment2 =
            new PaymentContext(new PayPalPayment());

        payment2.ExecutePayment(2500);
    }
}