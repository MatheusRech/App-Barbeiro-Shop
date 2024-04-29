using Rech.Barbeiro.Shop.Database.Base;
using Rech.Barbeiro.Shop.Database.Repositorio.Base;
using Rech.Barbeiro.Shop.Database.Repositorio.Interface;
using Rech.Barbeiro.Shop.Domain.Agendamento;

namespace Rech.Barbeiro.Shop.Database.Repositorio
{
    public class AgendamentoRepositorio : RepositorioBase<AgendamentoEntidade>, IAgendamentoRepositorio
    {
        public AgendamentoRepositorio(ContextoDatabase contexto) : base(contexto)
        {
        }
    }
}
