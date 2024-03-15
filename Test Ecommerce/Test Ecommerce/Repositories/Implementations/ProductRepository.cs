using Dapper;
using Microsoft.Data.SqlClient;
using System.Data;
using Test_Ecommerce.Repositories.Base;
using Test_Ecommerce.Repositories.Interfaces;
using Test_Ecommerce.Repositories.Models;

namespace Test_Ecommerce.Repositories.Implementations
{
    public class ProductRepository : IProductRepository
    {
        private readonly DBContext _dbContext;
        public ProductRepository(DBContext dbContext) 
        {
            _dbContext = dbContext;
        }

        public async Task AddProductAsync(Product product)
        {
            using (var connection = _dbContext.CreateConnection())
            {
                var sql = "INSERT INTO Products (Name, Email) VALUES (@Name, @Categroy,@Price)";                
                var rowsAffected = await connection.ExecuteAsync(sql, product);
            }
        }
    }
}
