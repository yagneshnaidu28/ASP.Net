using System;
using System.Threading.Tasks;

namespace KeywordDemoApp
{
    // --- Structural Keywords: interface, enum, struct, class ---
    public interface IGreetable
    {
        string Greet();
    }

    public enum Status
    {
        Active,
        Inactive
    }

    public struct Point
    {
        public int X;
        public int Y;
    }

    public class Person : IGreetable
    {
        // --- Modifiers: private, readonly, static, const ---
        private readonly string name;
        public const string Species = "Human";
        public static int InstanceCount = 0;

        // --- Constructor using 'this' ---
        public Person(string name)
        {
            this.name = name;
            InstanceCount++;
        }

        // --- Virtual keyword ---
        public virtual string Greet()
        {
            return $"Hello, my name is {name}.";
        }
    }

    public class Employee : Person
    {
        // --- base keyword ---
        public Employee(string name) : base(name) { }

        // --- override keyword ---
        public override string Greet()
        {
            return base.Greet() + " I am an employee.";
        }
    }

    class Program
    {
        // --- Asynchronous Keywords: async, Task, await, void ---
        public static async Task Main(string[] args)
        {
            // --- Primitive & Type Keywords: bool, int, double, char, string, object, var ---
            bool isValid = true;
            int count = 10;
            double price = 19.99;
            char grade = 'A';
            string message = "Welcome";
            object obj = "Universal Box";
            var implicitVar = 42; // implicitly typed variable

            // --- Type checking and casting: is, as ---
            if (obj is string strVal)
            {
                Console.WriteLine($"Object is string: {strVal}");
            }

            string castedStr = obj as string;

            // --- Conditional Keywords: if, else, switch, case, default ---
            if (isValid && count > 5)
            {
                Console.WriteLine("Condition met.");
            }
            else
            {
                Console.WriteLine("Condition failed.");
            }

            int choice = 2;
            switch (choice)
            {
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                default:
                    Console.WriteLine("Default");
                    break;
            }

            // --- Loop & Jump Keywords: for, foreach, while, do, break, continue, return ---
            for (int i = 0; i < 3; i++)
            {
                if (i == 1) continue;
                Console.WriteLine($"For loop index: {i}");
            }

            int w = 0;
            while (w < 1)
            {
                w++;
            }

            do
            {
                break;
            } while (false);

            string[] items = { "Apple", "Banana" };
            foreach (string item in items)
            {
                Console.WriteLine($"Item: {item}");
            }

            // --- Exception Handling Keywords: try, catch, finally, throw, null, true, false ---
            try
            {
                string text = null;
                if (text == null)
                {
                    throw new ArgumentNullException(nameof(text), "Text cannot be null.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Caught exception: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Cleanup executed in finally block.");
            }

            // --- Awaiting async task ---
            await Task.Delay(100);
            Console.WriteLine("Async task completed successfully.");
        }
    }
}