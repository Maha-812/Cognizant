using System;
using System.Collections.Generic;

interface IObserver
{
    void Update(string message);
}

class MobileClient : IObserver
{
    private string name;

    public MobileClient(string name)
    {
        this.name = name;
    }

    public void Update(string message)
    {
        Console.WriteLine(name + " received: " + message);
    }
}

class StockMarket
{
    private List<IObserver> observers = new List<IObserver>();

    public void Register(IObserver observer)
    {
        observers.Add(observer);
    }

    public void NotifyObservers(string message)
    {
        foreach (var observer in observers)
        {
            observer.Update(message);
        }
    }
}

class Program
{
    static void Main()
    {
        StockMarket stock = new StockMarket();

        MobileClient user1 = new MobileClient("Alice");
        MobileClient user2 = new MobileClient("Bob");

        stock.Register(user1);
        stock.Register(user2);

        stock.NotifyObservers("Stock Price Updated!");
    }
}