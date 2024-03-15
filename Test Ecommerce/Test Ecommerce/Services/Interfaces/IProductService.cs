using Test_Ecommerce.Models;

namespace Test_Ecommerce.Services.Interfaces
{
    public interface IProductService
    {
        Task AddProductAsync(Product product);
    }
}
