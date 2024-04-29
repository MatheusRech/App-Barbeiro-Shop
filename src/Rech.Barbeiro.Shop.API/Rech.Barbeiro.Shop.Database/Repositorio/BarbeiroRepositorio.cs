using Rech.Barbeiro.Shop.Database.Base;
using Rech.Barbeiro.Shop.Database.Repositorio.Base;
using Rech.Barbeiro.Shop.Database.Repositorio.Interface;
using Rech.Barbeiro.Shop.Domain.Barbeiro;

namespace Rech.Barbeiro.Shop.Database.Repositorio
{
    public class BarbeiroRepositorio : RepositorioBase<BarbeiroEntidade>, IBarbeiroRepositorio
    {
        public BarbeiroRepositorio(ContextoDatabase contexto) : base(contexto)
        {
        }
    }
}
