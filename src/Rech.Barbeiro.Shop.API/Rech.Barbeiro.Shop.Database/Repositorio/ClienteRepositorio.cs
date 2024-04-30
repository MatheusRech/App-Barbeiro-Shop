using Rech.Barbeiro.Shop.Database.Base;
using Rech.Barbeiro.Shop.Database.Repositorio.Base;
using Rech.Barbeiro.Shop.Domain.Cliente;
using Rech.Barbeiro.Shop.Domain.Interfaces;

namespace Rech.Barbeiro.Shop.Database.Repositorio
{
    public class ClienteRepositorio : RepositorioBase<ClienteEntidade>, IClienteRepositorio
    {
        public ClienteRepositorio(ContextoDatabase contexto) : base(contexto)
        {
        }
    }
}
