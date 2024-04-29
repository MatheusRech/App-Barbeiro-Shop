using Rech.Barbeiro.Shop.Domain.Base;
using Rech.Barbeiro.Shop.Domain.Enums;

namespace Rech.Barbeiro.Shop.Domain.Barbearia
{
    public class BarbeariaEntidade : Entidade
    {
        public required string Nome { get; set; }
        public required Plano Plano { get; set; }
        public required string Logo { get; set; }
        public required string Endereco { get; set; }
        public required string Descricao { get; set; }
        public required Guid UsuarioId { get; set; }
    }
}
