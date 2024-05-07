using Microsoft.AspNetCore.Mvc;
using Rech.Barbeiro.Shop.Domain.Barbearia.Comandos;
using Rech.Barbeiro.Shop.Domain.Barbearia.Respostas;
using Rech.Barbeiro.Shop.Servicos.Mediator.Interfaces;
using System.ComponentModel;

namespace Rech.Barbeiro.Shop.API.Controllers.Barbearia.v1
{
    /// <summary>
    /// Reune endpoints destinados ao gerenciamento das barbearias.
    /// </summary>
    [ApiController]
    [ApiVersion("1.0")]
    [ControllerName("Barbearia")]
    [Route("v{version:apiVersion}/[controller]")]
    [Produces("application/json")]
    [Description("Reune endpoints destinados ao gerenciamento das barbearias.")]
    [ApiExplorerSettings(GroupName = "Barbearia")]
    public class BarbeariaController : ControllerBase
    {
        private readonly ITransactionMediator _transactionMediator;

        public BarbeariaController(ITransactionMediator transactionMediator)
        {
            _transactionMediator = transactionMediator;
        }
        /// <summary>
        /// Cadastra a barbearia
        /// </summary>
        /// <param name="comando">Comando para o cadastro da barbearia</param>
        /// <response code="200">Barbearia cadastrada com sucesso.</response>
        /// <response code="400">Ocorreu um erro de negócio.</response>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType<CadastrarBarbeariaResposta>(200)]
        [ProducesResponseType<CadastrarBarbeariaResposta>(400)]

        public async Task<IActionResult> Cadastrar([FromBody] CadastrarBarbeariaComando comando)
        {
            var resposta = await _transactionMediator.EnviarComando(comando);

            if(resposta.Sucesso)
                return Ok(resposta);
            else
                return BadRequest(resposta);
        }

        [HttpPut]
        public async Task<IActionResult> Atualizar([FromBody] AtualizarBarbeariaComando comando)
        {
            var resposta = await _transactionMediator.EnviarComando(comando);

            if (resposta.Sucesso)
                return Ok(resposta);
            else
                return BadRequest(resposta);
        }
    }
}
