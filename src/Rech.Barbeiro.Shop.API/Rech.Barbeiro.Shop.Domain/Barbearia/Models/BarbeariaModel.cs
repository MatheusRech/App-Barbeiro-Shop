namespace Rech.Barbeiro.Shop.Domain.Barbearia.Models
{
    public class BarbeariaModel
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Logo { get; set; }
        public string Endereco { get; set; }
        public string Descricao { get; set; }
        public Guid UsuarioId { get; set; }

        public static BarbeariaModel FromEntidade(BarbeariaEntidade entidade)
        {
            return new BarbeariaModel
            {
                Id = entidade.Id,
                Nome = entidade.Nome,
                Logo = entidade.Logo,
                Endereco = entidade.Endereco,
                Descricao = entidade.Descricao,
                UsuarioId = entidade.UsuarioId
            };
        }
    }
}
