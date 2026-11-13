// Console.WriteLine("Hello, World!,yagnesh ");


/* Console.Write("Enter your name: ");
string? name = Console.ReadLine();


Console.WriteLine($"Hello, {name}! Welcome to C#."); */



// Check if any arguments were passed


/* if (args.Length <= 0)
{
    Console.WriteLine($"no argument received");
}
else
{
    Console.WriteLine($"arguments passed are {args[0]}and {args[1]}");
} */



/* Console.Write("Enter your age: ");
string? input = Console.ReadLine();

if (int.TryParse(input, out int age))
{
    Console.WriteLine($"Next year, you will be {age + 1} years old.");
}
else
{
    Console.WriteLine("Invalid number entered.");
} */


Console.Write("Enter your birth date (YYYY-MM-DD): ");
string? dateInput = Console.ReadLine();


if (DateTime.TryParse(dateInput, out DateTime birthDate))
{
    Console.WriteLine($"You were born on a {birthDate.DayOfWeek}.");
}
else
{
    Console.WriteLine("Invalid date format entered.");
}