using Rech.Barbeiro.Shop.Domain.Barbearia;
using Rech.Barbeiro.Shop.Domain.Base;

namespace Rech.Barbeiro.Shop.Domain.Barbeiro
{
    public class BarbeiroEntidade : Entidade
    {
        public required Guid BarbeariaId { get; set; }
        public virtual BarbeariaEntidade Barbearia { get; set; }
        public required string Nome { get; set; }
    }
}
