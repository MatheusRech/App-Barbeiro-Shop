using Rech.Barbeiro.Shop.Domain.Barbearia;
using Rech.Barbeiro.Shop.Domain.Base;

namespace Rech.Barbeiro.Shop.Domain.ServicoBarbearia
{
    public class ServicoBarbeariaEntidade : Entidade
    {
        public required Guid BarbeariaId { get; set; }
        public virtual BarbeariaEntidade Barbearia { get; set; }
        public required string Descricao { get; set; }
        public required double Valor { get; set; }
        public required double TempoExecucao { get; set; }
    }
}
