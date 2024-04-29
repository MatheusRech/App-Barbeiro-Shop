using Rech.Barbeiro.Shop.Domain.Barbeiro;
using Rech.Barbeiro.Shop.Domain.Base;
using Rech.Barbeiro.Shop.Domain.Enums;
using Rech.Barbeiro.Shop.Domain.ServicoBarbearia;

namespace Rech.Barbeiro.Shop.Domain.Barbearia
{
    public class BarbeariaEntidade : Entidade
    {
        public required string Nome { get; set; }
        public required string Logo { get; set; }
        public required string Endereco { get; set; }
        public string Descricao { get; set; }
        public required Guid UsuarioId { get; set; }
        public virtual IEnumerable<BarbeiroEntidade> Barbeiros { get; set; }
        public virtual IEnumerable<ServicoBarbeariaEntidade> Servicos { get; set; }
    }
}
