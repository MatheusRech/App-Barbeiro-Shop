using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rech.Barbeiro.Shop.Domain.DiasTrabalhoBarbeiro;

namespace Rech.Barbeiro.Shop.Database.Base.ConfigDomain
{
    public class DiasTrabalhoBarbeiroEntidadeConfigDb : IEntityTypeConfiguration<DiasTrabalhoBarbeiroEntidade>
    {
        public void Configure(EntityTypeBuilder<DiasTrabalhoBarbeiroEntidade> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Barbeiro).WithMany(x => x.DiasTrabalho).HasForeignKey(x => x.BarbeiroId).IsRequired();

            builder.Property(x => x.DiaDaSemana).IsRequired();
            builder.Property(x => x.HorarioInicio).IsRequired();
            builder.Property(x => x.HorarioFim).IsRequired();
            builder.Property(x => x.RealizaAlmoco).IsRequired();
        }
    }
}
