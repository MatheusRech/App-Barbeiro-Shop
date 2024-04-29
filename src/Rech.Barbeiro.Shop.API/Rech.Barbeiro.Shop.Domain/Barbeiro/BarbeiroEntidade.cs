using Rech.Barbeiro.Shop.Domain.Agendamento;
using Rech.Barbeiro.Shop.Domain.AgendamentoFolga;
using Rech.Barbeiro.Shop.Domain.Barbearia;
using Rech.Barbeiro.Shop.Domain.Base;
using Rech.Barbeiro.Shop.Domain.DiasTrabalhoBarbeiro;
using Rech.Barbeiro.Shop.Domain.ServicoBarbeiro;

namespace Rech.Barbeiro.Shop.Domain.Barbeiro
{
    public class BarbeiroEntidade : Entidade
    {
        public required Guid BarbeariaId { get; set; }
        public virtual BarbeariaEntidade Barbearia { get; set; }
        public required string Nome { get; set; }
        public virtual IEnumerable<AgendamentoEntidade> Agendamentos { get; set; }
        public virtual IEnumerable<AgendamentoFolgaEntidade> Folgas { get; set; }
        public virtual IEnumerable<DiasTrabalhoBarbeiroEntidade> DiasTrabalho { get; set; }
        public virtual IEnumerable<ServicoBarbeiroEntidade> Servicos { get; set; }
    }
}
