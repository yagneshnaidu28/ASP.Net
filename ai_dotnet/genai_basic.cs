using Microsoft.Extensions.AI;
using OpenAI;

class Program
{
    static async Task Main(string[] args)
    {
        // 1. Our Private Knowledge Base (Documents)
        var knowledgeBase = new List<string>
        {
            "Student Yagnesh Naidu is working on a .NET 10 ASP.NET Core Web API with MySQL.",
            "The university library operating hours are Monday through Friday, 8:00 AM to 8:00 PM.",
            "Entity Framework Core Code-First migrations are applied using 'dotnet ef database update'."
        };

        // 2. User Question
        string userQuery = "How do I apply EF Core migrations in my project?";

        // 3. RETRIEVAL STEP: Find the most relevant document snippet
        // (In production, you use vector embeddings & cosine similarity. Here we use keyword matching for simplicity)
        string retrievedContext = knowledgeBase
            .FirstOrDefault(doc => doc.Contains("migrations", StringComparison.OrdinalIgnoreCase)) 
            ?? "No relevant context found.";

        Console.WriteLine($"[Retrieved Context]: {retrievedContext}\n");

        // 4. AUGMENTATION STEP: Combine context and prompt
        string augmentedPrompt = $"""
            You are a helpful technical assistant. Answer the user's question accurately 
            using ONLY the provided context below. If you don't know, say so.

            Context:
            {retrievedContext}

            Question:
            {userQuery}
            """;

        // 5. GENERATION STEP: Send to LLM via Microsoft.Extensions.AI (IChatClient)
        // Works with OpenAI, Azure, or local models via Ollama
        IChatClient client = new OpenAIClient("your-api-key-here")
            .GetChatClient("gpt-4o-mini")
            .AsIChatClient();

        Console.WriteLine("Generating response from LLM...");
        var response = await client.GetResponseAsync(augmentedPrompt);

        // 6. Output the RAG Result
        Console.WriteLine($"\n[AI Answer]:\n{response.Text}");
    }
}