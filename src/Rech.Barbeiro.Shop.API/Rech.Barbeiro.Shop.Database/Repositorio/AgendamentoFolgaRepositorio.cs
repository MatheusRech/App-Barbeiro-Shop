using Rech.Barbeiro.Shop.Database.Base;
using Rech.Barbeiro.Shop.Database.Repositorio.Base;
using Rech.Barbeiro.Shop.Domain.AgendamentoFolga;
using Rech.Barbeiro.Shop.Domain.Interfaces;

namespace Rech.Barbeiro.Shop.Database.Repositorio
{
    public class AgendamentoFolgaRepositorio : RepositorioBase<AgendamentoFolgaEntidade>, IAgendamentoFolgaRepositorio
    {
        public AgendamentoFolgaRepositorio(ContextoDatabase contexto) : base(contexto)
        {
        }
    }
}
