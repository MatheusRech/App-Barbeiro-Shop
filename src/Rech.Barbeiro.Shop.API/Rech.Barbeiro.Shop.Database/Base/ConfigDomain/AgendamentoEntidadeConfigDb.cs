using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rech.Barbeiro.Shop.Domain.Agendamento;

namespace Rech.Barbeiro.Shop.Database.Base.ConfigDomain
{
    public class AgendamentoEntidadeConfigDb : IEntityTypeConfiguration<AgendamentoEntidade>
    {
        public void Configure(EntityTypeBuilder<AgendamentoEntidade> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Cliente).WithMany(x => x.Agendamentos).HasForeignKey(x => x.ClienteId).IsRequired();
            builder.HasOne(x => x.Barbeiro).WithMany(x => x.Agendamentos).HasForeignKey(x => x.BarberioId).IsRequired();
            builder.HasOne(x => x.Servico).WithMany(x => x.Agendamentos).HasForeignKey(x => x.ServicoId).IsRequired();

            builder.Property(x => x.Horario).IsRequired();
        }
    }
}
