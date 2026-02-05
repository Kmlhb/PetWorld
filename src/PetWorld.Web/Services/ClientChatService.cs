using PetWorld.Application.UseCases;
using PetWorld.Domain.Entities;
using PetWorld.Domain.Interfaces;

namespace PetWorld.Web.Services;

public class ClientChatService
{
    private readonly HandleClientQuestionUseCase _useCase;
    private readonly IChatRepo _repo;

    public ClientChatService(
        HandleClientQuestionUseCase useCase,
        IChatRepo repo)
    {
        _useCase = useCase;
        _repo = repo;
    }

    public Task<ClientChatMessage> SendQuestionAsync(string q)
        => _useCase.ExecuteAsync(q);

    public Task<List<ClientChatMessage>> GetHistoryAsync()
        => _repo.GetAllAsync();
}