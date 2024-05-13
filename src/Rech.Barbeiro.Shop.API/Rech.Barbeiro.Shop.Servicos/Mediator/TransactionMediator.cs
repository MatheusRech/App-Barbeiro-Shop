using MediatR;
using Rech.Barbeiro.Shop.API.Helpers.Models;
using Rech.Barbeiro.Shop.Database.Base;
using Rech.Barbeiro.Shop.Servicos.Mediator.Interfaces;

namespace Rech.Barbeiro.Shop.Servicos.Mediator
{
    public class TransactionMediator : ITransactionMediator
    {
        private readonly ContextoDatabase _contextoDatabase;
        private readonly IMediator _mediator;

        public TransactionMediator(ContextoDatabase contextoDatabase, IMediator mediator)
        {
            _contextoDatabase = contextoDatabase;
            _mediator = mediator;
        }

        public async Task<RespostaComando> EnviarComando<T>(T comando)
        {
            var tiboComando = typeof(T);
            Type tipoResposta = tiboComando.BaseType.GetGenericArguments()[0];

            if(tiboComando.BaseType.Name != "Comando`1" && tipoResposta.BaseType != typeof(RespostaComando))
                throw new ArgumentException("O tipo base não está conforme");
            
            var transacao = await _contextoDatabase.Database.BeginTransactionAsync();

            try
            {
                var resposta = (await _mediator.Send(comando)) as RespostaComando;

                if (!resposta.Sucesso)
                    await transacao.RollbackAsync();
                else
                    await transacao.CommitAsync();

                return resposta;

            }
            catch (Exception)
            {
                await transacao.RollbackAsync();
                throw;
            }
        }
    }
}
