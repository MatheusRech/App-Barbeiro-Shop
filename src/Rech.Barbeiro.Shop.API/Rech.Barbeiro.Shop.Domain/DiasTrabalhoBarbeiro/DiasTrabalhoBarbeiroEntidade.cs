using Rech.Barbeiro.Shop.Domain.Barbeiro;
using Rech.Barbeiro.Shop.Domain.Enums;

namespace Rech.Barbeiro.Shop.Domain.DiasTrabalhoBarbeiro
{
    public class DiasTrabalhoBarbeiroEntidade
    {
        public required Guid BarbeiroId { get; set; }
        public virtual BarbeiroEntidade Barbeiro { get; set; }
        public required DiaDaSemana DiaDaSemana { get; set; }
        public required double[] Horarios { get; set; }
    }
}
