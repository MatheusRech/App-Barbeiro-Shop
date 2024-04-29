using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rech.Barbeiro.Shop.Domain.Cliente;

namespace Rech.Barbeiro.Shop.Database.Base.ConfigDomain
{
    public class ClienteEntidadeConfigDb : IEntityTypeConfiguration<ClienteEntidade>
    {
        public void Configure(EntityTypeBuilder<ClienteEntidade> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasIndex(x => x.UsuarioId);

            builder.Property(x => x.Documento).IsRequired().HasMaxLength(11);
            builder.Property(x => x.Nome).IsRequired().HasMaxLength(90);
            builder.Property(x => x.Idade).IsRequired();
            builder.Property(x => x.UsuarioId).IsRequired();
        }
    }
}
