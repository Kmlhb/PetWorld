namespace PetWorld.Application.AI;

public class AgentRunner
{
    private readonly WriterAgent _writer = new();
    private readonly CriticAgent _critic = new();

    public async Task<(string answer, int iterations)> RunAsync(
        string question, List<string> products)
    {
        string answer = "";
        int it = 0;

        for (int i = 0; i < 3; i++)
        {
            it++;
            answer = await _writer.GenerateAsync(question, products);
            var (ok, _) = await _critic.EvaluateAsync(answer);

            if (ok) return (answer, it);
        }

        return (answer, it);
    }
}