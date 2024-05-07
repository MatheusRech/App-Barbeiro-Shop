using MediatR;
using Rech.Barbeiro.Shop.Domain.Barbearia.Comandos;
using Rech.Barbeiro.Shop.Domain.Barbearia.Models;
using Rech.Barbeiro.Shop.Domain.Barbearia.Respostas;
using Rech.Barbeiro.Shop.Domain.Exceptions;
using Rech.Barbeiro.Shop.Domain.Interfaces;

namespace Rech.Barbeiro.Shop.Domain.Barbearia.Handlers
{
    public class AtualizarBarbeariaComandoHandler : IRequestHandler<AtualizarBarbeariaComando, AtualizarBarbeariaResposta>
    {
		private readonly IBarbeariaRepositorio _barbeariaRepositorio;

        public AtualizarBarbeariaComandoHandler(IBarbeariaRepositorio barbeariaRepositorio)
        {
            _barbeariaRepositorio = barbeariaRepositorio;
        }

        public async Task<AtualizarBarbeariaResposta> Handle(AtualizarBarbeariaComando request, CancellationToken cancellationToken)
        {
			try
			{
				request.Validar();

				var barbearia = await _barbeariaRepositorio.BuscarPorId(request.Id);

				if (barbearia is null)
					return new AtualizarBarbeariaResposta("Barbearia não cadastrada");

				barbearia.Nome = request.Nome;
				barbearia.Endereco = request.Endereco;
				barbearia.Descricao = request.Descricao;
				barbearia.Logo = request.Logo;

				await _barbeariaRepositorio.Atualizar(barbearia);

				return new AtualizarBarbeariaResposta(BarbeariaModel.FromEntidade(barbearia));

            }
			catch (DomainException ex)
			{
				return new AtualizarBarbeariaResposta(ex.Message);
			}
			catch (Exception ex)
			{

				return new AtualizarBarbeariaResposta($"Ocorreu um erro ao tentar atualizar as informações da barbearia {request.Id}. Erro: {ex.Message}. Stacktrace: {ex.StackTrace}");
			}
        }
    }
}
