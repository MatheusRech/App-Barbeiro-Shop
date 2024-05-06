using Rech.Barbeiro.Shop.Domain.Barbeiro;
using Rech.Barbeiro.Shop.Domain.Base;
using Rech.Barbeiro.Shop.Domain.Enums;

namespace Rech.Barbeiro.Shop.Domain.DiasTrabalhoBarbeiro
{
    public class DiasTrabalhoBarbeiroEntidade : Entidade
    {
        public required Guid BarbeiroId { get; set; }
        public virtual BarbeiroEntidade Barbeiro { get; set; }
        public required DiaDaSemana DiaDaSemana { get; set; }
        public required TimeOnly HorarioInicio { get; set; }
        public required TimeOnly HorarioFim { get; set; }
        public required bool RealizaAlmoco { get; set; }
        public TimeOnly? HorarioInicioAlmoco { get; set; }
        public TimeOnly? HorarioFimAlmoco { get; set; }
    }
}
