namespace Rech.Barbeiro.Shop.Domain.Base
{
    public abstract class RespostaComando
    {
        public bool Sucesso { get; set; }
        public string Erro { get; set; }
    }
}
