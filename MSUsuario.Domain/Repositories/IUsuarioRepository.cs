using MSUsuario.Domain.Models;

namespace MSUsuario.Domain.Repositories
{
    public interface IUsuarioRepository
    {
        Task<Usuario> Inserir();
    }
}
