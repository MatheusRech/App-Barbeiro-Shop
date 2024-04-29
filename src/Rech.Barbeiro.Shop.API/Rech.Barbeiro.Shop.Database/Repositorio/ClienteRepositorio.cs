using Rech.Barbeiro.Shop.Database.Base;
using Rech.Barbeiro.Shop.Database.Repositorio.Base;
using Rech.Barbeiro.Shop.Database.Repositorio.Interface;
using Rech.Barbeiro.Shop.Domain.Cliente;

namespace Rech.Barbeiro.Shop.Database.Repositorio
{
    public class ClienteRepositorio : RepositorioBase<ClienteEntidade>, IClienteRepositorio
    {
        public ClienteRepositorio(ContextoDatabase contexto) : base(contexto)
        {
        }
    }
}
