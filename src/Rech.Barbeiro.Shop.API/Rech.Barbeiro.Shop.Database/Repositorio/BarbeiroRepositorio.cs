using Rech.Barbeiro.Shop.Database.Base;
using Rech.Barbeiro.Shop.Database.Repositorio.Base;
using Rech.Barbeiro.Shop.Domain.Barbeiro;
using Rech.Barbeiro.Shop.Domain.Interfaces;

namespace Rech.Barbeiro.Shop.Database.Repositorio
{
    public class BarbeiroRepositorio : RepositorioBase<BarbeiroEntidade>, IBarbeiroRepositorio
    {
        public BarbeiroRepositorio(ContextoDatabase contexto) : base(contexto)
        {
        }
    }
}
