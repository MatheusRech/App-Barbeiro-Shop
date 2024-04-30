using MediatR;
using Rech.Barbeiro.Shop.Domain.Base;

namespace Rech.Barbeiro.Shop.Domain.Barbearia.Comandos
{
    public class CadastrarBarbeariaComando : IRequest<RespostaComando>
    {
        public Guid UsuarioId { get; set; }
        public string Nome { get; set; }
        public string Logo { get; set; }
        public string Endereco { get; set; }
    }
}
