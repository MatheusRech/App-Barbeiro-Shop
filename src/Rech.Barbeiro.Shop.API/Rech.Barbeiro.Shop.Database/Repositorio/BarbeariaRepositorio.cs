using Rech.Barbeiro.Shop.Database.Base;
using Rech.Barbeiro.Shop.Database.Repositorio.Base;
using Rech.Barbeiro.Shop.Domain.Barbearia;
using Rech.Barbeiro.Shop.Domain.Interfaces;

namespace Rech.Barbeiro.Shop.Database.Repositorio
{
    public class BarbeariaRepositorio : RepositorioBase<BarbeariaEntidade>, IBarbeariaRepositorio
    {
        public BarbeariaRepositorio(ContextoDatabase contexto) : base(contexto)
        {
        }
    }
}
