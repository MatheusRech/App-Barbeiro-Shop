using Rech.Barbeiro.Shop.Domain.Agendamento;
using Rech.Barbeiro.Shop.Domain.Base;
using Rech.Barbeiro.Shop.Domain.ClienteEndereco;

namespace Rech.Barbeiro.Shop.Domain.Cliente
{
    public class ClienteEntidade : Entidade
    {
        public required string Documento { get; set; }
        public required Guid UsuarioId { get; set; }
        public required string Nome { get; set; }
        public required int Idade { get; set; }
        public virtual ClienteEnderecoEntidade Endereco { get; set; }
        public virtual IEnumerable<AgendamentoEntidade> Agendamentos { get; set; }
    }
}
