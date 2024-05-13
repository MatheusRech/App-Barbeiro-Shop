using Rech.Barbeiro.Shop.API.Helpers.Models;

namespace Rech.Barbeiro.Shop.Domain.Usuario.Resposta
{
    public class CadastrarUsuarioResposta : RespostaComando
    {
        public Guid UsuarioId { get; set; }

        public CadastrarUsuarioResposta(Guid usuarioId)
        {
            UsuarioId = usuarioId;
            Sucesso = true;
        }

        public CadastrarUsuarioResposta(string erro)
        {
            Erro = erro;
            Sucesso = false;
        }
    }
}
