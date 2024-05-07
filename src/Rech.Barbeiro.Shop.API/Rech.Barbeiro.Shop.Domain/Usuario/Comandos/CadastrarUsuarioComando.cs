using Rech.Barbeiro.Shop.Domain.Base;
using Rech.Barbeiro.Shop.Domain.Usuario.Resposta;
using System.Text;

namespace Rech.Barbeiro.Shop.Domain.Usuario.Comandos
{
    public class CadastrarUsuarioComando : Comando<CadastrarUsuarioResposta>
    {
        public string Username { get; set; }
        public string Senha { get; set; }
        public string ConfirmacaoSenha { get; set; }
        public override void Validar()
        {
            var erros = new StringBuilder();

            if (string.IsNullOrEmpty(Username))
                erros.AppendLine("O campo username é obrigatorio");

            if (string.IsNullOrEmpty(Senha))
                erros.AppendLine("O campo senha é obrigatorio");

            if (string.IsNullOrEmpty(ConfirmacaoSenha))
                erros.AppendLine("O campo confirmação da senha é obrigatorio");
            else if (Senha != ConfirmacaoSenha)
                erros.AppendLine("As senhas não são iguais");
        }
    }
}
