using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rech.Barbeiro.Shop.Domain.ServicoBarbearia;

namespace Rech.Barbeiro.Shop.Database.Base.ConfigDomain
{
    public class ServicoBarbeariaEntidadeConfigDb : IEntityTypeConfiguration<ServicoBarbeariaEntidade>
    {
        public void Configure(EntityTypeBuilder<ServicoBarbeariaEntidade> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Barbearia).WithMany(x => x.Servicos).HasForeignKey(x => x.BarbeariaId).IsRequired();

            builder.Property(x => x.Descricao).IsRequired().HasMaxLength(60);
            builder.Property(x => x.Valor).IsRequired();
            builder.Property(x => x.TempoExecucao).IsRequired();
        }
    }
}
