using Rech.Barbeiro.Shop.API.Helpers.Models;

namespace Rech.Barbeiro.Shop.Servicos.Mediator.Interfaces
{
    public interface ITransactionMediator
    {
        Task<RespostaComando> EnviarComando<T>(T comando);
    }
}
