using Rech.Barbeiro.Shop.Database.Base;
using Rech.Barbeiro.Shop.Database.Repositorio.Base;
using Rech.Barbeiro.Shop.Database.Repositorio.Interface;
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
