namespace PetWorld.Domain.Entities;

public class ClientChatMessage
{
    public int Id { get; set; }
    public string Question { get; set; }
    public string Answer { get; set; }
    public int Iterations { get; set; }
    public DateTime CreatedAt { get; set; }
}