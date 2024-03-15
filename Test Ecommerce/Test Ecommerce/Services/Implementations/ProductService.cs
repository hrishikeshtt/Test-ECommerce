using Test_Ecommerce.Models;
using Test_Ecommerce.Repositories.Interfaces;
using Test_Ecommerce.Services.Interfaces;

namespace Test_Ecommerce.Services.Implementations
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        public ProductService(
            IProductRepository productRepository
            )
        {
            _productRepository= productRepository;
        }
        public async Task AddProductAsync(Product product)
        {
            var prouctRepoModel = new Repositories.Models.Product
            {
                Category = product.Category,
                Description = product.Description,
                Name = product.Name,
                Price = product.Price,
                Rating = product.Rating,
                Stock = product.Stock,
                Weight = product.Weight
            };
            await _productRepository.AddProductAsync(prouctRepoModel);
        }
    }
}
