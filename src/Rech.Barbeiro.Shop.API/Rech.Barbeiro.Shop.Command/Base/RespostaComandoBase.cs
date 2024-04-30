namespace Rech.Barbeiro.Shop.Command.Base
{
    public class RespostaComandoBase
    {
        public bool Sucesso { get; set; }
        public string Erro { get; set; }

        public static RespostaComandoBase RespostaSucesso()
        {
            return new()
            {
                Sucesso = true
            };
        }

        public static RespostaComandoBase RespostaErro(string erro)
        {
            return new()
            {
                Sucesso = false,
                Erro = erro
            };
        }
    }
}
