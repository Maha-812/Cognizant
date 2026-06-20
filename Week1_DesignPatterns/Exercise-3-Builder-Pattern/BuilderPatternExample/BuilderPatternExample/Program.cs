using System;

class Computer
{
    public string CPU;
    public string RAM;

    public void Show()
    {
        Console.WriteLine($"CPU: {CPU}");
        Console.WriteLine($"RAM: {RAM}");
    }
}

class ComputerBuilder
{
    private Computer computer = new Computer();

    public ComputerBuilder SetCPU(string cpu)
    {
        computer.CPU = cpu;
        return this;
    }

    public ComputerBuilder SetRAM(string ram)
    {
        computer.RAM = ram;
        return this;
    }

    public Computer Build()
    {
        return computer;
    }
}

class Program
{
    static void Main()
    {
        Computer computer = new ComputerBuilder()
            .SetCPU("Intel i7")
            .SetRAM("16GB")
            .Build();

        computer.Show();
    }
}