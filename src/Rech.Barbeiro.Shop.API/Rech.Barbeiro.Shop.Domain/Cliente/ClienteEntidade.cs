using Rech.Barbeiro.Shop.Domain.Barbearia;
using Rech.Barbeiro.Shop.Domain.Base;

namespace Rech.Barbeiro.Shop.Domain.Cliente
{
    public class ClienteEntidade : Entidade
    {
        public required Guid BarbeariaId { get; set; }
        public virtual BarbeariaEntidade Barbearia { get; set; }
        public required string Documento { get; set; }
        public required Guid UsuarioId { get; set; }
        public required string Nome { get; set; }
        public required int Idade { get; set; }
    }
}
