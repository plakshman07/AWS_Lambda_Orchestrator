using Orchestrator;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Starting local orchestration...");

        var workflow = new Workflow();
        await workflow.Run();

        Console.WriteLine("Finished orchestration.");
    }
}
