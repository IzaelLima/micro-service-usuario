using Microsoft.AspNetCore.Mvc;
using MSUsuario.Api.ViewModel;
using MSUsuario.Application.Interfaces;

namespace MSUsuario.Api.Controller
{
    [Route("v{version:apiVersion}/usuarios")]
    [ApiVersion("1")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioApp _usuarioApp;

        public UsuarioController(IUsuarioApp usuarioApp)
        {
            _usuarioApp = usuarioApp;
        }

        [HttpPost]
        public async Task<IActionResult> SalvarUsuario(AdicionarUsuarioViewModel.Request request, CancellationToken cancellationToken)
        {
            var resultado = _usuarioApp.Inserir(request, cancellationToken);
            return Ok(resultado);
        }
    }
}
