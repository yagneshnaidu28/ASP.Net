using System;

// 1. Define your class first
class Calculator
{
    public int Add(int a, int b) => a + b;
}

// 2. Wrap your execution logic inside Program.Main or keep top-level code at the very top
class Program
{
    static void Main(string[] args)
    {
        Calculator calc = new Calculator();
        int result = calc.Add(5, 10);
        Console.WriteLine(result);
    }
}