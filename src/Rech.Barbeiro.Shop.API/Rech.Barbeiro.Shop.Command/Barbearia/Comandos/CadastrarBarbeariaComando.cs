using MediatR;
using Rech.Barbeiro.Shop.Command.Base;

namespace Rech.Barbeiro.Shop.Command.Barbearia.Comandos
{
    public class CadastrarBarbeariaComando : IRequest<RespostaComandoBase>
    {
        public Guid UsuarioId { get; set; }
        public string Nome { get; set; }
        public string Logo { get; set; }
        public string Endereco { get; set; }

    }
}
