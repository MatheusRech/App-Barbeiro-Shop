using MediatR;
using Rech.Barbeiro.Shop.Domain.Barbearia.Respostas;
using Rech.Barbeiro.Shop.Domain.Base;
using Rech.Barbeiro.Shop.Domain.Exceptions;
using System.Text;

namespace Rech.Barbeiro.Shop.Domain.Barbearia.Comandos
{
    public class AtualizarBarbeariaComando : Comando<AtualizarBarbeariaResposta>
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Descricao { get; set; }
        public string Logo { get; set; }

        public override void Validar()
        {
            var erros = new StringBuilder();

            if (string.IsNullOrEmpty(Nome) || string.IsNullOrWhiteSpace(Nome))
                erros.AppendLine("O campo nome deve ser informado");
            else if (Nome.Length > 120)
                erros.AppendLine("O campo nome deve conter no maximo 120 carcteres");

            if (string.IsNullOrEmpty(Logo))
                erros.AppendLine("O campo logo deve ser informado");

            if (string.IsNullOrEmpty(Endereco))
                erros.AppendLine("O campo endereco deve ser informado");
            else if (Endereco.Length > 300)
                erros.AppendLine("O campo endereco deve conter no maximo 300 carcteres");

            if (Descricao is not null && Descricao.Length > 1000)
                erros.AppendLine("O campo endereco deve conter no maximo 1000 carcteres");

            if (erros.Length > 0)
                throw new DomainException(erros.ToString());
        }
    }
}
