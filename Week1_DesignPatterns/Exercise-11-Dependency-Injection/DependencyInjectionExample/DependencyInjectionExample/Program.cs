using System;

interface ICustomerRepository
{
    string FindCustomerById(int id);
}

class CustomerRepository : ICustomerRepository
{
    public string FindCustomerById(int id)
    {
        return "Customer ID: " + id + ", Name: Mahalakshmi";
    }
}

class CustomerService
{
    private readonly ICustomerRepository repository;

    public CustomerService(ICustomerRepository repository)
    {
        this.repository = repository;
    }

    public void GetCustomer(int id)
    {
        Console.WriteLine(repository.FindCustomerById(id));
    }
}

class Program
{
    static void Main(string[] args)
    {
        ICustomerRepository repository =
            new CustomerRepository();

        CustomerService service =
            new CustomerService(repository);

        service.GetCustomer(101);
    }
}