using Rech.Barbeiro.Shop.Domain.Barbeiro;
using Rech.Barbeiro.Shop.Domain.Base;
using Rech.Barbeiro.Shop.Domain.Enums;
using Rech.Barbeiro.Shop.Domain.ServicoBarbearia;

namespace Rech.Barbeiro.Shop.Domain.Barbearia
{
    public class BarbeariaEntidade : Entidade
    {
        public string Nome { get; set; }
        public string Logo { get; set; }
        public string Endereco { get; set; }
        public string Descricao { get; set; }
        public Guid UsuarioId { get; set; }
        public virtual IEnumerable<BarbeiroEntidade> Barbeiros { get; set; }
        public virtual IEnumerable<ServicoBarbeariaEntidade> Servicos { get; set; }

        public BarbeariaEntidade(string nome, string logo, string endereco, Guid usuarioId)
        {
            Nome = nome;
            Logo = logo;
            Endereco = endereco;
            UsuarioId = usuarioId;
        }
    }
}
