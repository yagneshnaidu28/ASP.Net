/* // ==========================================
// PART 1: ARRAYS IN C#
// ==========================================

// 1. Single-Dimensional Arrays
int[] numbers = { 5, 2, 9, 1, 7 };
string[] names = new string[3] { "Alice", "Bob", "Charlie" };

// Access and modification
numbers[0] = 10;
Console.WriteLine($"First number: {numbers[0]}");
Console.WriteLine($"Array length: {numbers.Length}");

// Built-in Array Methods
Array.Sort(numbers);                   // Sorts ascending
Array.Reverse(numbers);                // Reverses order
int index = Array.IndexOf(numbers, 7); // Find index of element 7
Console.WriteLine($"Index of 7: {index}");

// 2. Multidimensional Arrays (Rectangular 2D)
int[,] matrix = {
    { 1, 2, 3 },
    { 4, 5, 6 }
};
Console.WriteLine($"Matrix element [1,2]: {matrix[1, 2]}"); // Output: 6

// 3. Jagged Arrays (Array of Arrays)
int[][] jaggedArray = new int[2][];
jaggedArray[0] = new int[] { 1, 2 };
jaggedArray[1] = new int[] { 3, 4, 5 };
Console.WriteLine($"Jagged [1][2]: {jaggedArray[1][2]}"); // Output: 5
 */
/* 
// ==========================================
// PART 2: STRING OPERATIONS IN C#
// ==========================================

string message = "  Hello, C# World!  ";

// 1. Length & Indexing
Console.WriteLine($"Length: {message.Length}");

// 2. Case Conversion
Console.WriteLine($"Upper: {message.ToUpper()}");
Console.WriteLine($"Lower: {message.ToLower()}");

// 3. Trimming Whitespace
string trimmed = message.Trim(); 
Console.WriteLine($"Trimmed: '{trimmed}'");

// 4. Searching & Checking
bool containsCsharp = trimmed.Contains("C#");
bool startsWithHello = trimmed.StartsWith("Hello");
bool endsWithExclamation = trimmed.EndsWith("!");
int subIndex = trimmed.IndexOf("World");
Console.WriteLine($"Contains 'C#': {containsCsharp}, Starts with 'Hello': {startsWithHello}");

// 5. Extraction & Substrings
string sub = trimmed.Substring(7, 2); // "C#" (start index, length)
Console.WriteLine($"Substring: {sub}");

// 6. Modification & Replacement
string replaced = trimmed.Replace("World", "Developer"); 
Console.WriteLine($"Replaced: {replaced}");

// 7. Splitting and Joining
string csv = "apple,banana,orange";
string[] fruitsArray = csv.Split(',');                 // Splits string into array
string rejoined = string.Join(" | ", fruitsArray);     // Joins array back into string
Console.WriteLine($"Rejoined: {rejoined}");

// 8. String Interpolation
string user = "Developer";
int score = 95;
string formatted = $"User: {user}, Score: {score}";
Console.WriteLine(formatted);

// 9. StringBuilder (Efficient for heavy string modifications)
System.Text.StringBuilder sb = new System.Text.StringBuilder();
sb.Append("Line 1");
sb.AppendLine();
sb.Append("Line 2");
string finalString = sb.ToString();
Console.WriteLine($"StringBuilder output:\n{finalString}"); */