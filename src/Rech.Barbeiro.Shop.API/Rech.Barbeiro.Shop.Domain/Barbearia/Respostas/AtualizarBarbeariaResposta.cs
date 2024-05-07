using Rech.Barbeiro.Shop.Domain.Barbearia.Models;
using Rech.Barbeiro.Shop.Domain.Base;

namespace Rech.Barbeiro.Shop.Domain.Barbearia.Respostas
{
    public class AtualizarBarbeariaResposta : RespostaComando
    {
        public BarbeariaModel Barbearia { get; set; }

        public AtualizarBarbeariaResposta(BarbeariaModel barbearia)
        {
            Sucesso = true;
            Barbearia = barbearia;
        }

        public AtualizarBarbeariaResposta(string erro)
        {
            Sucesso = false;
            Erro = erro;
        }
    }
}
