using MSUsuario.Api.ViewModel;

namespace MSUsuario.Application.Interfaces
{
    public interface IUsuarioApp
    {
        Task<AdicionarUsuarioViewModel.Response> Inserir(AdicionarUsuarioViewModel.Request request, CancellationToken cancellationToken);
    }
}
