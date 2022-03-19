using System;
using MSUsuario.Api.ViewModel;
using MSUsuario.Application.Interfaces;
using MSUsuario.Domain.Repositories;

namespace MSUsuario.Application.Usuario
{
    public class UsuarioApp : IUsuarioApp
    {
        private readonly IUsuarioRepository _usuarioRepository;
        public UsuarioApp(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public async Task<AdicionarUsuarioViewModel.Response> Inserir(AdicionarUsuarioViewModel.Request request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
