namespace Rech.Barbeiro.Shop.Domain.Base
{
    public class RespostaComando
    {
        public bool Sucesso { get; set; }
        public string Erro { get; set; }
        public object Data { get; set; }

        public static RespostaComando RespostaSucesso(object data = null)
        {
            return new RespostaComando
            {
                Sucesso = true,
                Data = data
            };
        }

        public static RespostaComando RespostaErro(string erro)
        {
            return new RespostaComando
            {
                Sucesso = false,
                Erro = erro
            };
        }
    }
}
