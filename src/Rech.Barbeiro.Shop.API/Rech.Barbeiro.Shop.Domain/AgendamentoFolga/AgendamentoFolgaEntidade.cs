using Rech.Barbeiro.Shop.Domain.Barbeiro;
using Rech.Barbeiro.Shop.Domain.Base;

namespace Rech.Barbeiro.Shop.Domain.AgendamentoFolga
{
    public class AgendamentoFolgaEntidade : Entidade
    {
        public required Guid BarbeiroId { get; set; }
        public virtual BarbeiroEntidade Barbeiro { get; set; }
        public required DateTime HorarioInicio { get; set; }
        public required DateTime HorarioFim { get; set; }
    }
}
