using PetWorld.Domain.Entities;

namespace PetWorld.Domain.Interfaces;

public interface IChatRepo
{
    Task SaveAsync(ClientChatMessage message);
    Task<List<ClientChatMessage>> GetAllAsync();
}