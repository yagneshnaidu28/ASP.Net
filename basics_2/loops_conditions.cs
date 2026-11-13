/* // --- Operators ---
int a = 10, b = 20;
int sum = a + b;                // Arithmetic operator
bool isGreater = b > a;         // Relational operator
bool isValid = (a < b && b > 15); // Logical operator

// --- Conditional Statements (if-else & switch) ---
if (sum > 25)
{
    Console.WriteLine("Sum is greater than 25.");
}
else
{
    Console.WriteLine("Sum is 25 or less.");
}

int choice = 2;
switch (choice)
{
    case 1:
        Console.WriteLine("Choice is one.");
        break;
    case 2:
        Console.WriteLine("Choice is two.");
        break;
    default:
        Console.WriteLine("Default choice.");
        break;
}

// --- Loops (for, while, do-while, foreach) ---
for (int i =0;i<=4;i++)
{
    Console.WriteLine(i);
}

int a=5;
while(a>=2)
{
    Console.WriteLine(a);
    a--;
}

int num = 0;
do
{
    Console.WriteLine($"Do-while number: {num}");
    num++;
} while (num < 1);





string[] fruits = { "Apple", "Banana", "Cherry" };
foreach (string fruit in fruits)
{
    Console.WriteLine($"Fruit: {fruit}");
}


int[] numbers = { 10, 20, 30 };
for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine($"Index {i}: {numbers[i]}");
}


int[] number = { 10, 20, 30 };
foreach (int num in number)
{
    Console.WriteLine(num);
}








int day = 2;
string dayName = day switch
{
    1 => "Monday",
    2 => "Tuesday",
    3 => "Wednesday",
    _ => "Invalid day" // '_' acts as the default case
};
Console.WriteLine(dayName);




// --- 1. BREAK STATEMENT ---
// Exits a loop or switch statement entirely before it finishes naturally.
Console.WriteLine("--- 1. BREAK Statement ---");
for (int i = 1; i <= 5; i++)
{
    if (i == 3)
    {
        Console.WriteLine("Reached 3. Breaking out of the loop.");
        break; // Stops the loop completely
    }
    Console.WriteLine($"Current number: {i}");
}


// --- 2. CONTINUE STATEMENT ---
// Skips the current iteration of a loop and immediately jumps to the next iteration.
Console.WriteLine("\n--- 2. CONTINUE Statement ---");
for (int i = 1; i <= 5; i++)
{
    if (i == 3)
    {
        Console.WriteLine("Skipping number 3.");
        continue; // Skips printing 3 and moves to i = 4
    }
    Console.WriteLine($"Current number: {i}");
}


// --- 3. GOTO STATEMENT ---
// Transfers program control directly to a labeled section of code.
Console.WriteLine("\n--- 3. GOTO Statement ---");
int counter = 1;

StartJump: // This is a label
if (counter <= 2)
{
    Console.WriteLine($"Goto counter: {counter}");
    counter++;
    goto StartJump; // Jumps execution back to the label
}


// --- 4. RETURN STATEMENT ---
// Exits the current method or function and optionally returns a value to the caller.
Console.WriteLine("\n--- 4. RETURN Statement ---");
int CalculateSum(int a, int b)
{
    return a + b; // Exits the function immediately and returns the result
}

int sumResult = CalculateSum(10, 20);
Console.WriteLine($"Sum returned: {sumResult}");


// --- 5. THROW STATEMENT ---
// Signals that a runtime error or exceptional condition has occurred.
Console.WriteLine("\n--- 5. THROW Statement ---");
try
{
    int age = -5;
    if (age < 0)
    {
        throw new ArgumentOutOfRangeException(nameof(age), "Age cannot be negative.");
    }
}
catch (Exception ex)
{
    Console.WriteLine($"Caught an exception: {ex.Message}");
} */



