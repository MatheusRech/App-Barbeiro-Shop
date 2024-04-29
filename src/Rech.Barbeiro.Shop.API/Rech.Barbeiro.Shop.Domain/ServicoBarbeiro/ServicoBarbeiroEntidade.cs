using Rech.Barbeiro.Shop.Domain.Barbeiro;
using Rech.Barbeiro.Shop.Domain.Base;
using Rech.Barbeiro.Shop.Domain.ServicoBarbearia;

namespace Rech.Barbeiro.Shop.Domain.ServicoBarbeiro
{
    public class ServicoBarbeiroEntidade : Entidade
    {
        public required Guid BarbeiroId { get; set; }
        public virtual BarbeiroEntidade Barbeiro { get; set; }
        public required Guid ServicoId { get; set; }
        public virtual ServicoBarbeariaEntidade Servico { get; set; }
    }
}
