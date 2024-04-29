using Rech.Barbeiro.Shop.Database.Base;
using Rech.Barbeiro.Shop.Database.Repositorio.Base;
using Rech.Barbeiro.Shop.Database.Repositorio.Interface;
using Rech.Barbeiro.Shop.Domain.Barbearia;

namespace Rech.Barbeiro.Shop.Database.Repositorio
{
    public class BarbeariaRepositorio : RepositorioBase<BarbeariaEntidade>, IBarbeariaRepositorio
    {
        public BarbeariaRepositorio(ContextoDatabase contexto) : base(contexto)
        {
        }
    }
}
