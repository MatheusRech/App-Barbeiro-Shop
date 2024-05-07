using MediatR;

namespace Rech.Barbeiro.Shop.Domain.Base
{
    public abstract class Comando<TReposta> : IRequest<TReposta>
    {
        /// <summary>
        /// Dispara uma exceção de dominio caso a validação falhe
        /// </summary>
        /// <exception cref="DomainException"></exception>
        public abstract void Validar();
    }
}
