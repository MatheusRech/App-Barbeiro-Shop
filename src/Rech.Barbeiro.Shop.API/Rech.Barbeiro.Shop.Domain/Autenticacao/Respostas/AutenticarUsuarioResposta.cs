using Rech.Barbeiro.Shop.API.Helpers.Models;

namespace Rech.Barbeiro.Shop.Domain.Autenticacao.Respostas
{
    public class AutenticarUsuarioResposta : RespostaComando
    {
        public string Token { get; set; }

        public AutenticarUsuarioResposta(bool sucesso, string token = null, string erro = null)
        {
            Token = token;
            Sucesso = sucesso;
            Erro = erro;
        }
    }
}
