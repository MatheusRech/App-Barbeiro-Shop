using Microsoft.AspNetCore.Identity;
using Rech.Barbeiro.Shop.Domain.Barbearia;

namespace Rech.Barbeiro.Shop.Domain.Usuario
{
    public class UsuarioEntidade : IdentityUser<Guid>
    {
        public Guid BarbeariaId { get; set; }
        public virtual BarbeariaEntidade Barbearia { get; set; }
        public UsuarioEntidade(string userName, Guid barbeariaId) : base(userName)
        {
            BarbeariaId = barbeariaId;
        }
    }
}
