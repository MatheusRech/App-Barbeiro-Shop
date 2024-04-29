using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rech.Barbeiro.Shop.Domain.Barbearia;

namespace Rech.Barbeiro.Shop.Database.Base.ConfigDomain
{
    public class BarbeariaEntidadeConfigDb : IEntityTypeConfiguration<BarbeariaEntidade>
    {
        public void Configure(EntityTypeBuilder<BarbeariaEntidade> builder)
        {
            builder.HasKey(x => x.Id);
            
            builder.HasIndex(x => x.UsuarioId);
            
            builder.Property(x => x.Nome).IsRequired().HasMaxLength(120);
            builder.Property(x => x.Logo).IsRequired();
            builder.Property(x => x.Endereco).IsRequired().HasMaxLength(300);
            builder.Property(x => x.Descricao).IsRequired(false).HasMaxLength(1000);
        }
    }
}
