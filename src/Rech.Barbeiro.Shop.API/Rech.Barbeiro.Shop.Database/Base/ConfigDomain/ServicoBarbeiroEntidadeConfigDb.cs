using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rech.Barbeiro.Shop.Domain.ServicoBarbeiro;

namespace Rech.Barbeiro.Shop.Database.Base.ConfigDomain
{
    public class ServicoBarbeiroEntidadeConfigDb : IEntityTypeConfiguration<ServicoBarbeiroEntidade>
    {
        public void Configure(EntityTypeBuilder<ServicoBarbeiroEntidade> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Barbeiro).WithMany(x => x.Servicos).HasForeignKey(x => x.BarbeiroId).IsRequired();
            builder.HasOne(x => x.Servico).WithMany(x => x.ServicosBarbeiros).HasForeignKey(x => x.ServicoId).IsRequired();
        }
    }
}
