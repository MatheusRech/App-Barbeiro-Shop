using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rech.Barbeiro.Shop.Domain.AgendamentoFolga;

namespace Rech.Barbeiro.Shop.Database.Base.ConfigDomain
{
    public class AgendamentoFolgaEntidadeConfigDb : IEntityTypeConfiguration<AgendamentoFolgaEntidade>
    {
        public void Configure(EntityTypeBuilder<AgendamentoFolgaEntidade> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Barbeiro).WithMany(x => x.Folgas).HasForeignKey(x => x.BarbeiroId).IsRequired();

            builder.Property(x => x.HorarioInicio).IsRequired();
            builder.Property(x => x.HorarioFim).IsRequired();
        }
    }
}
