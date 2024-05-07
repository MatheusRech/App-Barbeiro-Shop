using MediatR;
using Rech.Barbeiro.Shop.Database.Base;
using Rech.Barbeiro.Shop.Domain.Base;
using Rech.Barbeiro.Shop.Servicos.Mediator.Interfaces;

namespace Rech.Barbeiro.Shop.Servicos.Mediator
{
    public class TransactionMediator : ITransactionMediator
    {
        private readonly ContextoDatabase _contextoDatabase;
        private readonly IMediator _mediator;

        public TransactionMediator(ContextoDatabase contextoDatabase)
        {
            _contextoDatabase = contextoDatabase;
        }

        public async Task<RespostaComando> EnviarComando<T>(T comando)
        {
            if(!(comando is Comando<RespostaComando>))
                throw new ArgumentException($"O tipo {typeof(T)} não é um comando válido.");

            var transacao = await _contextoDatabase.Database.BeginTransactionAsync();

            try
            {
                var resposta = await _mediator.Send(comando as Comando<RespostaComando>);

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
