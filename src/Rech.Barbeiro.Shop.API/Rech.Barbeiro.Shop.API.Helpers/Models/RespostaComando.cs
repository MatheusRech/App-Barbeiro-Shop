namespace Rech.Barbeiro.Shop.API.Helpers.Models
{
    public abstract class RespostaComando
    {
        public bool Sucesso { get; set; }
        public string Erro { get; set; }
    }
}
