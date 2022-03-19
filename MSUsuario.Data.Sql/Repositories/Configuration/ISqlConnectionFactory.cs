using System.Data;

namespace MSUsuario.Data.Sql.Repository.Configuration
{
    public interface ISqlConnectionFactory
    {
        IDbConnection Criar(string connectionStringName); 
    }
}
