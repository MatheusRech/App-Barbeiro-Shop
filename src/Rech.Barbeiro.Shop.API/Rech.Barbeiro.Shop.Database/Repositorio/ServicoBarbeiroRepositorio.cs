using Rech.Barbeiro.Shop.Database.Base;
using Rech.Barbeiro.Shop.Database.Repositorio.Base;
using Rech.Barbeiro.Shop.Domain.Interfaces;
using Rech.Barbeiro.Shop.Domain.ServicoBarbeiro;

namespace Rech.Barbeiro.Shop.Database.Repositorio
{
    public class ServicoBarbeiroRepositorio : RepositorioBase<ServicoBarbeiroEntidade>, IServicoBarbeiroRepositorio
    {
        public ServicoBarbeiroRepositorio(ContextoDatabase contexto) : base(contexto)
        {
        }
    }
}
