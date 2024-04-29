using Rech.Barbeiro.Shop.Database.Base;
using Rech.Barbeiro.Shop.Database.Repositorio.Base;
using Rech.Barbeiro.Shop.Database.Repositorio.Interface;
using Rech.Barbeiro.Shop.Domain.ClienteEndereco;

namespace Rech.Barbeiro.Shop.Database.Repositorio
{
    public class ClienteEnderecoRepositorio : RepositorioBase<ClienteEnderecoEntidade>, IClienteEnderecoRepositorio
    {
        public ClienteEnderecoRepositorio(ContextoDatabase contexto) : base(contexto)
        {
        }
    }
}
