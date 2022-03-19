using System.Diagnostics.CodeAnalysis;
using Microsoft.Extensions.DependencyInjection;
using MSUsuario.Application.Interfaces;
using MSUsuario.Application.Usuario;

namespace MSUsuario.Application
{
    [ExcludeFromCodeCoverage]
    public static class ServicesExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.RegistrarServices();

            return services;   
        }
        public static void RegistrarServices(this IServiceCollection services)
        {
            services.AddTransient<IUsuarioApp, UsuarioApp>();
        }
    }
}
