using System;
using System.Collections.Generic;

class Product
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public int Quantity { get; set; }

    public Product(int id, string name, int qty)
    {
        ProductId = id;
        ProductName = name;
        Quantity = qty;
    }
}

class Program
{
    static void Main()
    {
        List<Product> inventory = new List<Product>();

        inventory.Add(new Product(101, "Laptop", 10));
        inventory.Add(new Product(102, "Mouse", 25));
        inventory.Add(new Product(103, "Keyboard", 15));

        Console.WriteLine("Inventory Products:");

        foreach (var product in inventory)
        {
            Console.WriteLine(
                $"ID: {product.ProductId}, Name: {product.ProductName}, Quantity: {product.Quantity}");
        }
    }
}