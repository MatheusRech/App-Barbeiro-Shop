using Microsoft.AspNetCore.Identity;

namespace Rech.Barbeiro.Shop.Domain.Usuario
{
    public class UsuarioEntidade : IdentityUser<Guid>
    {

        public UsuarioEntidade(string username) : base(username)
        {
        }
    }
}
