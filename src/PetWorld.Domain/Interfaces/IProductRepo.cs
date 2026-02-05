namespace PetWorld.Domain.Interfaces;

public interface IProductRepo
{
    Task<List<string>> GetAllProductsAsync();
}