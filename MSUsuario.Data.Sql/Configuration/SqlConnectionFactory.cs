using Microsoft.Extensions.Configuration;
using MSUsuario.Data.Sql.Repository.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace MSUsuario.Data.Sql.Configuration
{
    public class SqlConnectionFactory : ISqlConnectionFactory
    {
        private readonly IConfiguration _configuration;
        public SqlConnectionFactory(IConfiguration configuration)
        {
            _configuration = configuration; 
        }

        public IDbConnection Criar(string connectionStringName)
        {
            var connectionString = _configuration.GetConnectionString(connectionStringName);
            var sqlConnection = new SqlConnection(connectionString);

            sqlConnection.Open();  
            
            return sqlConnection;  
        }
    }
}
