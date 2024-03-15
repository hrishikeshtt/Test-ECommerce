

using Test_Ecommerce.Repositories.Models;

namespace Test_Ecommerce.Repositories.Interfaces
{
    public interface IProductRepository
    {
        Task AddProductAsync(Product product);
    }
}
