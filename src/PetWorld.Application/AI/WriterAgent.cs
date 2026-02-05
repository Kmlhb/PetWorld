namespace PetWorld.Application.AI;

public class WriterAgent
{
    public Task<string> GenerateAsync(string question, List<string> products)
    {
        // MOCK AI (na potrzeby zadania)
        return Task.FromResult(
            $"OdpowiedŸ AI dla: '{question}' — rekomendujê produkty z katalogu."
        );
    }
}