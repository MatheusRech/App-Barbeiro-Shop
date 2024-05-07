using Microsoft.AspNetCore.Mvc;
using Rech.Barbeiro.Shop.Domain.Usuario.Comandos;
using Rech.Barbeiro.Shop.Domain.Usuario.Resposta;
using Rech.Barbeiro.Shop.Servicos.Mediator.Interfaces;
using System.ComponentModel;

namespace Rech.Barbeiro.Shop.API.Controllers.Usuario.v1
{
    [ApiController]
    [ApiVersion("1.0")]
    [ControllerName("Usuario")]
    [Route("v{version:apiVersion}/[controller]")]
    [Produces("application/json")]
    [Description("Reune endpoints destinados ao gerenciamento dos usuarios do sistema.")]
    [ApiExplorerSettings(GroupName = "Usuario")]
    public class UsuarioController : ControllerBase
    {
        private readonly ITransactionMediator _transactionMediator;

        public UsuarioController(ITransactionMediator transactionMediator)
        {
            _transactionMediator = transactionMediator;
        }

        [HttpPost]
        [ProducesResponseType<CadastrarUsuarioResposta>(200)]
        [ProducesResponseType<CadastrarUsuarioResposta>(400)]
        public async Task<IActionResult> Cadastrar([FromBody] CadastrarUsuarioComando comando)
        {
            var resposta = await _transactionMediator.EnviarComando(comando);

            if (resposta.Sucesso)
            {
                return Ok(resposta);
            }
            else
            {
                return BadRequest(resposta);
            }
        }
    }
}
