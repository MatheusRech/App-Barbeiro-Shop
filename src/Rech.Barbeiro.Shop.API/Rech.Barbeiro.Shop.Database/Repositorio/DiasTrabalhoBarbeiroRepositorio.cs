using Rech.Barbeiro.Shop.Database.Base;
using Rech.Barbeiro.Shop.Database.Repositorio.Base;
using Rech.Barbeiro.Shop.Database.Repositorio.Interface;
using Rech.Barbeiro.Shop.Domain.DiasTrabalhoBarbeiro;

namespace Rech.Barbeiro.Shop.Database.Repositorio
{
    public class DiasTrabalhoBarbeiroRepositorio : RepositorioBase<DiasTrabalhoBarbeiroEntidade>, IDiasTrabalhoBarbeiroRepositorio
    {
        public DiasTrabalhoBarbeiroRepositorio(ContextoDatabase contexto) : base(contexto)
        {
        }
    }
}
