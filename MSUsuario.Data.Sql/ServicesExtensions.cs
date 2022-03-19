using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MSUsuario.Context;
using MSUsuario.Data.Sql.Configuration;
using MSUsuario.Data.Sql.Repository.Configuration;
using System.Diagnostics.CodeAnalysis;
using MSUsuario.Domain.Repositories;
using MSUsuario.Data.Sql.Repositories;

namespace MSUsuario.Data.Sql
{
    [ExcludeFromCodeCoverage]
    public static class ServicesExtensions
    {
        public static IServiceCollection AddInfraDataSqlServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<ISqlConnectionFactory, SqlConnectionFactory>();
            services.AddDbContext<SqlContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("Usuario")));
            services.AddScoped<SqlContext>();

            services.RegisterRepositories();

            return services;
        }

        public static void RegisterRepositories(this IServiceCollection services)
        {
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
        }
    }
}
