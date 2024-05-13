using Microsoft.AspNetCore.Mvc;
using Rech.Barbeiro.Shop.Domain.Autenticacao.Comandos;
using Rech.Barbeiro.Shop.Domain.Autenticacao.Respostas;
using Rech.Barbeiro.Shop.Servicos.Mediator.Interfaces;
using System.ComponentModel;

namespace Rech.Barbeiro.Shop.API.Controllers.Usuario.v1
{
    [ApiController]
    [ApiVersion("1.0")]
    [ControllerName("Autenticacao")]
    [Route("v{version:apiVersion}/[controller]")]
    [Produces("application/json")]
    [Description("Reune endpoints destinados a autenticação na plataforma.")]
    [ApiExplorerSettings(GroupName = "Usuario")]
    public class AutenticacaoController : ControllerBase
    {
        private readonly ITransactionMediator _transactionMediator;

        public AutenticacaoController(ITransactionMediator transactionMediator)
        {
            _transactionMediator = transactionMediator;
        }

        /// <summary>
        /// Autentica o usuario no sistema
        /// </summary>
        /// <param name="comando"></param>
        /// <returns>O token utilizado para a autenticação na API</returns>
        [HttpPost]
        [ProducesResponseType<AutenticarUsuarioResposta>(200)]
        [ProducesResponseType<AutenticarUsuarioResposta>(400)]
        public async Task<IActionResult> Autenticar([FromBody] AutenticarUsuarioComando comando)
        {
            var resposta = await _transactionMediator.EnviarComando(comando);

            if (resposta.Sucesso)
                return Ok(resposta);
            else
                return BadRequest(resposta);
        }
    }
}
