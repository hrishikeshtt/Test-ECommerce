using Microsoft.Data.SqlClient;
using System.Data;

namespace Test_Ecommerce.Repositories.Base
{
    public class DBContext
    {
        private readonly string _connectionString;

        public DBContext(IConfiguration configuration)
        {
            _connectionString = configuration["ConnectionString"];
        }
        public IDbConnection CreateConnection()
            => new SqlConnection(_connectionString);
    }
}
