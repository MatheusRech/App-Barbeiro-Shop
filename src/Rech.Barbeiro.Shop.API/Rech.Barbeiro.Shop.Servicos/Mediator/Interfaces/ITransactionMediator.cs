using Rech.Barbeiro.Shop.Domain.Base;

namespace Rech.Barbeiro.Shop.Servicos.Mediator.Interfaces
{
    public interface ITransactionMediator
    {
        Task<RespostaComando> EnviarComando<T>(T comando);
    }
}
