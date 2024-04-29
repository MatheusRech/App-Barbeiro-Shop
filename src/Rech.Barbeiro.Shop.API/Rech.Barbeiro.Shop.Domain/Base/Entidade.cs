namespace Rech.Barbeiro.Shop.Domain.Base
{
    public abstract class Entidade
    {
        public required Guid Id { get; set; }

        public required DateTime DataCriacao { get; set; }
        public DateTime DataAtualizacao { get; set; }
    }
}
