using Rech.Barbeiro.Shop.API.Helpers.Exceptions;
using Rech.Barbeiro.Shop.API.Helpers.Models;
using Rech.Barbeiro.Shop.Domain.Autenticacao.Respostas;
using System.Text;

namespace Rech.Barbeiro.Shop.Domain.Autenticacao.Comandos
{
    public class AutenticarUsuarioComando : Comando<AutenticarUsuarioResposta>
    {
        public string Cpf { get; set; }
        public string Senha { get; set; }
        public Guid BarbeariaId { get; set; }
        public override void Validar()
        {
            var erros = new StringBuilder();

            if (string.IsNullOrEmpty(Cpf))
                erros.AppendLine("O cpf deve ser informado");

            if (string.IsNullOrEmpty(Senha))
                erros.AppendLine("A senha deve ser informada");

            if (BarbeariaId == Guid.Empty)
                erros.AppendLine("O id da barbearia deve ser um id valido");

            if(erros.Length > 0)
                throw new DomainException(erros.ToString());
        }
    }
}
