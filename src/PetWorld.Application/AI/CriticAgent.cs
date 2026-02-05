namespace PetWorld.Application.AI;

public class CriticAgent
{
    public Task<(bool approved, string feedback)> EvaluateAsync(string answer)
    {
        // Mock — zawsze akceptuje
        return Task.FromResult((true, "OK"));
    }
}