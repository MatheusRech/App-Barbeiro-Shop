using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rech.Barbeiro.Shop.Domain.ClienteEndereco;

namespace Rech.Barbeiro.Shop.Database.Base.ConfigDomain
{
    public class ClienteEnderecoEntidadeConfigDb : IEntityTypeConfiguration<ClienteEnderecoEntidade>
    {
        public void Configure(EntityTypeBuilder<ClienteEnderecoEntidade> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Cliente).WithOne(x => x.Endereco).HasForeignKey<ClienteEnderecoEntidade>(x => x.ClienteId).IsRequired();

            builder.Property(x => x.Rua).IsRequired().HasMaxLength(60);
            builder.Property(x => x.Bairro).IsRequired().HasMaxLength(30);
            builder.Property(x => x.Cidade).IsRequired().HasMaxLength(45);
            builder.Property(x => x.Estado).IsRequired().HasMaxLength(40);
            builder.Property(x => x.Cep).IsRequired().HasMaxLength(8);
        }
    }
}
