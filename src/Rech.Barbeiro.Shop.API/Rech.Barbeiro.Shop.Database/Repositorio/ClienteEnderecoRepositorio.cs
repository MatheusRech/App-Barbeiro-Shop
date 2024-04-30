using Rech.Barbeiro.Shop.Database.Base;
using Rech.Barbeiro.Shop.Database.Repositorio.Base;
using Rech.Barbeiro.Shop.Domain.ClienteEndereco;
using Rech.Barbeiro.Shop.Domain.Interfaces;

namespace Rech.Barbeiro.Shop.Database.Repositorio
{
    public class ClienteEnderecoRepositorio : RepositorioBase<ClienteEnderecoEntidade>, IClienteEnderecoRepositorio
    {
        public ClienteEnderecoRepositorio(ContextoDatabase contexto) : base(contexto)
        {
        }
    }
}
