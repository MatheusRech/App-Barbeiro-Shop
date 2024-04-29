using Rech.Barbeiro.Shop.Domain.Base;
using Rech.Barbeiro.Shop.Domain.Cliente;

namespace Rech.Barbeiro.Shop.Domain.ClienteEndereco
{
    public class ClienteEnderecoEntidade : Entidade
    {
        public required Guid ClienteId { get; set; }
        public virtual ClienteEntidade Cliente { get; set; }
        public required string Rua { get; set; }
        public required string Bairro { get; set; }
        public required string Cidade { get; set; }
        public required string Estado { get; set; }
        public required string Cep { get; set; }
    }
}
