using Rech.Barbeiro.Shop.API.Helpers.Constantes;
using Rech.Barbeiro.Shop.API.Helpers.Exceptions;
using Rech.Barbeiro.Shop.API.Helpers.Models;
using Rech.Barbeiro.Shop.API.Helpers.Validadores;
using Rech.Barbeiro.Shop.Domain.Usuario.Resposta;
using System.Text;

namespace Rech.Barbeiro.Shop.Domain.Usuario.Comandos
{
    public class CadastrarUsuarioComando : Comando<CadastrarUsuarioResposta>
    {
        public Guid BarbeariaId { get; set; }
        public string Cpf { get; set; }
        public string Senha { get; set; }
        public string ConfirmacaoSenha { get; set; }
        public string Email { get; set; }
        public List<string> Permissoes { get; set; }

        public override void Validar()
        {
            var erros = new StringBuilder();

            if (string.IsNullOrEmpty(Cpf))
                erros.AppendLine("O campo cpf é obrigatorio");

            if (!CpfValidador.Validar(Cpf))
                erros.AppendLine("O CPF não é valido");

            if (string.IsNullOrEmpty(Senha))
                erros.AppendLine("O campo senha é obrigatorio");

            if (string.IsNullOrEmpty(ConfirmacaoSenha))
                erros.AppendLine("O campo confirmação da senha é obrigatorio");
            else if (Senha != ConfirmacaoSenha)
                erros.AppendLine("As senhas não são iguais");

            if(string.IsNullOrEmpty(Email))
                erros.AppendLine("O campo email é obrigatorio");

            if (Permissoes.Count == 0)
                erros.AppendLine("É necessario iformar ao menos uma permissão para o usuario");
            else if (Permissoes.Any(x => x != PermissoesUsuario.Admin && x != PermissoesUsuario.Cliente && x != PermissoesUsuario.Barbearia))
                erros.AppendLine("Uma os todas as permissões informadas não são validas");

            if (erros.Length > 0)
                throw new DomainException(erros.ToString());
        }
    }
}
