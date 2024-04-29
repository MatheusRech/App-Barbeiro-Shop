using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rech.Barbeiro.Shop.Domain.Barbeiro;

namespace Rech.Barbeiro.Shop.Database.Base.ConfigDomain
{
    public class BarbeiroEntidadeConfigDb : IEntityTypeConfiguration<BarbeiroEntidade>
    {
        public void Configure(EntityTypeBuilder<BarbeiroEntidade> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasIndex(x => x.BarbeariaId);
            builder.HasOne(x => x.Barbearia).WithMany(x => x.Barbeiros).HasForeignKey(x => x.BarbeariaId).IsRequired();

            builder.Property(x => x.Nome).IsRequired().HasMaxLength(90);
        }
    }
}
