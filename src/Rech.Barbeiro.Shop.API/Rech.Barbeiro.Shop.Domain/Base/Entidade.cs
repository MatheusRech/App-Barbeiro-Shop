namespace Rech.Barbeiro.Shop.Domain.Base
{
    public abstract class Entidade
    {
        public Guid Id { get; set; }

        public DateTime DataCriacao { get; set; }
        public DateTime DataAtualizacao { get; set; }
    }
}
