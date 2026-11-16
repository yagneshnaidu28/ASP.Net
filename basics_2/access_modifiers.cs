using System;

class Person
{
    // 1. PUBLIC: Accessible from anywhere
    public string Name = "Alice";

    // 2. PRIVATE: Accessible ONLY inside this class
    private string ssn = "123-45-6789";

    // 3. PROTECTED: Accessible inside this class and child classes
    protected string Hometown = "New York";

    // A public method can access private fields inside its own class
    public void RevealSsn()
    {
        Console.WriteLine($"Private SSN (accessed internally): {ssn}");
    }
}

// Child class inheriting from Person
class Employee : Person
{
    public void DisplayEmployeeInfo()
    {
        Console.WriteLine($"Name (Public): {Name}");          // Works!
        // Console.WriteLine(ssn);                         // ERROR! ssn is private to Person
        Console.WriteLine($"Hometown (Protected): {Hometown}"); // Works! Because Employee inherits Person
    }
}

class Program
{
    static void Main(string[] args)
    {
        Person person = new Person();
        Console.WriteLine($"Direct Public Access: {person.Name}"); // Works!
        
        // person.ssn = "999";       // ERROR! Cannot access private field outside class
        // person.Hometown = "Paris"; // ERROR! Cannot access protected field outside class

        person.RevealSsn(); // Works! Calls a public method that handles the private data

        Console.WriteLine("\n--- Child Class Access ---");
        Employee emp = new Employee();
        emp.DisplayEmployeeInfo();
    }
}