using System;
using System.Collections.Generic;

class Product
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public int Quantity { get; set; }
    public double Price { get; set; }

    public Product(int id, string name, int quantity, double price)
    {
        ProductId = id;
        ProductName = name;
        Quantity = quantity;
        Price = price;
    }
}

class Inventory
{
    private Dictionary<int, Product> products =
        new Dictionary<int, Product>();

    public void AddProduct(Product product)
    {
        products[product.ProductId] = product;
        Console.WriteLine("Product Added");
    }

    public void UpdateProduct(int id, int quantity)
    {
        if (products.ContainsKey(id))
        {
            products[id].Quantity = quantity;
            Console.WriteLine("Product Updated");
        }
    }

    public void DeleteProduct(int id)
    {
        if (products.Remove(id))
        {
            Console.WriteLine("Product Deleted");
        }
    }

    public void DisplayProducts()
    {
        Console.WriteLine("\nInventory:");

        foreach (var p in products.Values)
        {
            Console.WriteLine(
                $"ID:{p.ProductId}, Name:{p.ProductName}, Qty:{p.Quantity}, Price:{p.Price}");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Inventory inventory = new Inventory();

        inventory.AddProduct(
            new Product(101, "Laptop", 10, 50000));

        inventory.AddProduct(
            new Product(102, "Mouse", 25, 500));

        inventory.DisplayProducts();

        inventory.UpdateProduct(101, 15);

        inventory.DeleteProduct(102);

        inventory.DisplayProducts();
    }
}