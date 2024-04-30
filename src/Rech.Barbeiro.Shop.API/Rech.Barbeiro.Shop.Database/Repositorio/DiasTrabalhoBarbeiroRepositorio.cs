using Rech.Barbeiro.Shop.Database.Base;
using Rech.Barbeiro.Shop.Database.Repositorio.Base;
using Rech.Barbeiro.Shop.Domain.DiasTrabalhoBarbeiro;
using Rech.Barbeiro.Shop.Domain.Interfaces;

namespace Rech.Barbeiro.Shop.Database.Repositorio
{
    public class DiasTrabalhoBarbeiroRepositorio : RepositorioBase<DiasTrabalhoBarbeiroEntidade>, IDiasTrabalhoBarbeiroRepositorio
    {
        public DiasTrabalhoBarbeiroRepositorio(ContextoDatabase contexto) : base(contexto)
        {
        }
    }
}
