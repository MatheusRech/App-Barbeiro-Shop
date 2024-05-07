using MediatR;
using Microsoft.Extensions.Logging;
using Rech.Barbeiro.Shop.Domain.Barbearia.Comandos;
using Rech.Barbeiro.Shop.Domain.Barbearia.Models;
using Rech.Barbeiro.Shop.Domain.Barbearia.Respostas;
using Rech.Barbeiro.Shop.Domain.Exceptions;
using Rech.Barbeiro.Shop.Domain.Interfaces;

namespace Rech.Barbeiro.Shop.Domain.Barbearia.Handlers
{
    public class CadastrarBarbeariaComandoHandler : IRequestHandler<CadastrarBarbeariaComando, CadastrarBarbeariaResposta>
    {
        private readonly IBarbeariaRepositorio _barbeariaRepositorio;
        private readonly ILogger<CadastrarBarbeariaComandoHandler> _logger;

        public CadastrarBarbeariaComandoHandler(IBarbeariaRepositorio barbeariaRepositorio, ILogger<CadastrarBarbeariaComandoHandler> logger)
        {
            _barbeariaRepositorio = barbeariaRepositorio;
            _logger = logger;
        }

        public async Task<CadastrarBarbeariaResposta> Handle(CadastrarBarbeariaComando request, CancellationToken cancellationToken)
        {
            try
            {
                request.Validar();

                var barbearia = new BarbeariaEntidade(request.Nome, request.Logo, request.Endereco, request.UsuarioId);

                await _barbeariaRepositorio.Inserir(barbearia);

                return new CadastrarBarbeariaResposta(BarbeariaModel.FromEntidade(barbearia));
            }
            catch (DomainException ex)
            {
                return new CadastrarBarbeariaResposta(ex.Message);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ocorreu um erro ao tentar inserir a barbearia {0}. Mensagem de erro: {1} - Stacktrace: {2}", request.Nome, ex.Message, ex.StackTrace);
                return new CadastrarBarbeariaResposta($"Ocorreu um erro ao tentar inserir a barbearia {request.Nome}. Mensagem de erro: {ex.Message} - Stacktrace: {ex.StackTrace}");
            }
        }
    }
}
