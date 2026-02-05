using PetWorld.Domain.Entities;
using PetWorld.Domain.Interfaces;
using PetWorld.Application.AI;

namespace PetWorld.Application.UseCases;

public class HandleClientQuestionUseCase
{
    private readonly IProductRepo _productRepo;
    private readonly IChatRepo _chatRepo;
    private readonly AgentRunner _runner = new();

    public HandleClientQuestionUseCase(
        IProductRepo productRepo,
        IChatRepo chatRepo)
    {
        _productRepo = productRepo;
        _chatRepo = chatRepo;
    }

    public async Task<ClientChatMessage> ExecuteAsync(string question)
    {
        var products = await _productRepo.GetAllProductsAsync();

        var (answer, it) = await _runner.RunAsync(question, products);

        var msg = new ClientChatMessage
        {
            Question = question,
            Answer = answer,
            Iterations = it,
            CreatedAt = DateTime.UtcNow
        };

        await _chatRepo.SaveAsync(msg);

        return msg;
    }
}