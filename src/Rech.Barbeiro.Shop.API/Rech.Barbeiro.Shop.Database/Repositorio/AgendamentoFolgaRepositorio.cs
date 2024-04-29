using Rech.Barbeiro.Shop.Database.Base;
using Rech.Barbeiro.Shop.Database.Repositorio.Base;
using Rech.Barbeiro.Shop.Database.Repositorio.Interface;
using Rech.Barbeiro.Shop.Domain.AgendamentoFolga;

namespace Rech.Barbeiro.Shop.Database.Repositorio
{
    public class AgendamentoFolgaRepositorio : RepositorioBase<AgendamentoFolgaEntidade>, IAgendamentoFolgaRepositorio
    {
        public AgendamentoFolgaRepositorio(ContextoDatabase contexto) : base(contexto)
        {
        }
    }
}
