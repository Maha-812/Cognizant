using System;
using System.Collections.Generic;
using System.Linq;

class Product
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public string Category { get; set; }

    public Product(int id, string name, string category)
    {
        ProductId = id;
        ProductName = name;
        Category = category;
    }
}

class Program
{
    static Product LinearSearch(List<Product> products, string name)
    {
        foreach (var product in products)
        {
            if (product.ProductName.Equals(name,
                StringComparison.OrdinalIgnoreCase))
            {
                return product;
            }
        }
        return null;
    }

    static Product BinarySearch(Product[] products, string name)
    {
        int left = 0;
        int right = products.Length - 1;

        while (left <= right)
        {
            int mid = (left + right) / 2;

            int comparison =
                string.Compare(products[mid].ProductName,
                               name,
                               true);

            if (comparison == 0)
                return products[mid];

            if (comparison < 0)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return null;
    }

    static void Main(string[] args)
    {
        List<Product> products = new List<Product>()
        {
            new Product(101,"Laptop","Electronics"),
            new Product(102,"Mouse","Accessories"),
            new Product(103,"Keyboard","Accessories"),
            new Product(104,"Monitor","Electronics")
        };

        Console.WriteLine("Linear Search:");

        Product result1 =
            LinearSearch(products, "Mouse");

        if (result1 != null)
            Console.WriteLine(
                $"{result1.ProductId} - {result1.ProductName}");

        Product[] sortedProducts =
            products.OrderBy(p => p.ProductName).ToArray();

        Console.WriteLine("\nBinary Search:");

        Product result2 =
            BinarySearch(sortedProducts, "Monitor");

        if (result2 != null)
            Console.WriteLine(
                $"{result2.ProductId} - {result2.ProductName}");
    }
}