using MediatR;
using Microsoft.Extensions.Logging;
using Rech.Barbeiro.Shop.Domain.Barbearia.Comandos;
using Rech.Barbeiro.Shop.Domain.Base;
using Rech.Barbeiro.Shop.Domain.Interfaces;

namespace Rech.Barbeiro.Shop.Domain.Barbearia.Handlers
{
    public class CadastrarBarbeariaComandoHandler : IRequestHandler<CadastrarBarbeariaComando, RespostaComando>
    {
        private readonly IBarbeariaRepositorio _barbeariaRepositorio;
        private readonly ILogger<CadastrarBarbeariaComandoHandler> _logger;

        public CadastrarBarbeariaComandoHandler(IBarbeariaRepositorio barbeariaRepositorio, ILogger<CadastrarBarbeariaComandoHandler> logger)
        {
            _barbeariaRepositorio = barbeariaRepositorio;
            _logger = logger;
        }

        public async Task<RespostaComando> Handle(CadastrarBarbeariaComando request, CancellationToken cancellationToken)
        {
            try
            {
                var barbearia = new BarbeariaEntidade(request.Nome, request.Logo, request.Endereco, request.UsuarioId);

                await _barbeariaRepositorio.Inserir(barbearia);

                return RespostaComando.RespostaSucesso();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ocorreu um erro ao tentar inserir a barbearia {0}. Mensagem de erro: {1} - Stacktrace: {2}", request.Nome, ex.Message, ex.StackTrace);
                return RespostaComando.RespostaErro($"Ocorreu um erro ao tentar inserir a barbearia {request.Nome}. Mensagem de erro: {ex.Message} - Stacktrace: {ex.StackTrace}");
            }
        }
    }
}
