using Rech.Barbeiro.Shop.Domain.Barbeiro;
using Rech.Barbeiro.Shop.Domain.Cliente;
using Rech.Barbeiro.Shop.Domain.ServicoBarbearia;

namespace Rech.Barbeiro.Shop.Domain.Agendamento
{
    public class AgendamentoEntidade
    {
        public required Guid ClienteId { get; set; }
        public virtual ClienteEntidade Cliente { get; set; }
        public required Guid BarberioId { get; set; }
        public virtual BarbeiroEntidade Barbeiro { get; set; }
        public required Guid ServicoId { get; set; }
        public virtual ServicoBarbeariaEntidade Servico { get; set; }
        public required DateTime Horario { get; set; }
    }
}
