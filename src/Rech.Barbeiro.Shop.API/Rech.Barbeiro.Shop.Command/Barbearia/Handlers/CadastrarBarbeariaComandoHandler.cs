using MediatR;
using Rech.Barbeiro.Shop.Command.Barbearia.Comandos;
using Rech.Barbeiro.Shop.Command.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rech.Barbeiro.Shop.Command.Barbearia.Handlers
{
    public class CadastrarBarbeariaComandoHandler : IRequestHandler<CadastrarBarbeariaComando, RespostaComandoBase>
    {
        public async Task<RespostaComandoBase> Handle(CadastrarBarbeariaComando request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
