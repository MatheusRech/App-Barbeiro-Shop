using Rech.Barbeiro.Shop.Database.Base;
using Rech.Barbeiro.Shop.Database.Repositorio.Base;
using Rech.Barbeiro.Shop.Database.Repositorio.Interface;
using Rech.Barbeiro.Shop.Domain.ServicoBarbearia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rech.Barbeiro.Shop.Database.Repositorio
{
    public class ServicoBarbeariaRepositorio : RepositorioBase<ServicoBarbeariaEntidade>, IServicoBarbeariaRepositorio
    {
        public ServicoBarbeariaRepositorio(ContextoDatabase contexto) : base(contexto)
        {
        }
    }
}
