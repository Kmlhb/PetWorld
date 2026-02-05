using PetWorld.Domain.Entities;
using PetWorld.Domain.Interfaces;

namespace PetWorld.Infrastructure.Repositories;

public class MySqlChatRepository : IChatRepo
{
    private static List<ClientChatMessage> _db = new();

    public Task SaveAsync(ClientChatMessage message)
    {
        message.Id = _db.Count + 1;
        _db.Add(message);
        return Task.CompletedTask;
    }

    public Task<List<ClientChatMessage>> GetAllAsync()
    {
        return Task.FromResult(_db);
    }
}