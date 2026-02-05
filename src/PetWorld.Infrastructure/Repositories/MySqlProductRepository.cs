using PetWorld.Domain.Interfaces;

namespace PetWorld.Infrastructure.Repositories;

public class MySqlProductRepository : IProductRepo
{
    public Task<List<string>> GetAllProductsAsync()
    {
        var products = new List<string>
        {
            "Royal Canin Adult Dog",
            "Whiskas Adult Kurczak",
            "Tetra AquaSafe",
            "Trixie Drapak XL",
            "Kong Classic",
            "Ferplast Klatka",
            "Flexi Smycz",
            "Brit Premium Kitten",
            "JBL ProFlora CO2",
            "Vitapol Siano"
        };

        return Task.FromResult(products);
    }
}