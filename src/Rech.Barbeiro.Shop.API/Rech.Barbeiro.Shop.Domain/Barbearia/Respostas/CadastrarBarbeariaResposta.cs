using Rech.Barbeiro.Shop.API.Helpers.Models;
using Rech.Barbeiro.Shop.Domain.Barbearia.Models;

namespace Rech.Barbeiro.Shop.Domain.Barbearia.Respostas
{
    public class CadastrarBarbeariaResposta : RespostaComando
    {
        public BarbeariaModel Barbearia { get; set; }

        public CadastrarBarbeariaResposta(BarbeariaModel barbearia)
        {
            Sucesso = true;
            Barbearia = barbearia;
        }

        public CadastrarBarbeariaResposta(string erro)
        {
            Sucesso = false;
            Erro = erro;
        }
    }
}
