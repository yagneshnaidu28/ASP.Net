using System;

class Program
{
    // Class-level static field (acts like the C 'static' storage class, retaining state across calls)
    private static int staticCounter = 0;

    static void Main(string[] args)
    {
        Console.WriteLine("=== 1. FUNCTIONS, DEFINITIONS & PARAMETERS ===");
        
        // Actual parameters (arguments passed during function call)
        int actualX = 5, actualY = 10;
        
        // Function call
        int sum = AddNumbers(actualX, actualY);
        Console.WriteLine($"Sum: {sum}");

        // Parameter Passing: Call-by-Value vs Call-by-Reference
        int val = 20;
        ModifyByValue(val);
        Console.WriteLine($"After Call-by-Value: {val} (Unchanged)");

        int refVal = 20;
        ModifyByReference(ref refVal);
        Console.WriteLine($"After Call-by-Reference: {refVal} (Modified)");


        Console.WriteLine("\n=== 2. RECURSION ===");
        int resultFactorial = Factorial(5);
        Console.WriteLine($"Factorial of 5: {resultFactorial}");


        Console.WriteLine("\n=== 3. STORAGE CLASSES MAPPED TO C# ===");
        
        // 'auto' equivalent: Local automatic variables (created on stack, scoped to method)
        AutoStorageDemo();
        AutoStorageDemo();

        // 'static' equivalent: Persistent state across multiple function calls
        StaticStorageDemo();
        StaticStorageDemo();

        // Note on 'register' & 'extern':
        // - 'register': Modern C# and the .NET JIT compiler automatically optimize local variable register allocation.
        // - 'extern': Used in C# via DllImport for Interop to call external C/C++ native functions.
        Console.WriteLine("- Register: Managed automatically by JIT compiler optimization.");
        Console.WriteLine("- Extern: Used with DLL imports for native function integration.");
    }

    // --- FUNCTION DEFINITION ---
    // 'a' and 'b' are formal parameters
    static int AddNumbers(int a, int b)
    {
        return a + b;
    }

    // --- CALL-BY-VALUE ---
    static void ModifyByValue(int num)
    {
        num = 100; // Only modifies the local copy
    }

    // --- CALL-BY-REFERENCE ('ref' keyword) ---
    static void ModifyByReference(ref int num)
    {
        num = 100; // Modifies the original variable in memory
    }

    // --- RECURSION ---
    static int Factorial(int n)
    {
        // Base condition to stop recursion
        if (n <= 1)
        {
            return 1;
        }
        // Recursive call
        return n * Factorial(n - 1);
    }

    // --- AUTO STORAGE CLASS DEMO ---
    static void AutoStorageDemo()
    {
        int autoVar = 0; // Local automatic variable (re-initialized every call)
        autoVar++;
        Console.WriteLine($"Auto variable value: {autoVar}");
    }

    // --- STATIC STORAGE CLASS DEMO ---
    static void StaticStorageDemo()
    {
        staticCounter++; // Retains its value across different method calls
        Console.WriteLine($"Static variable persistent value: {staticCounter}");
    }
}