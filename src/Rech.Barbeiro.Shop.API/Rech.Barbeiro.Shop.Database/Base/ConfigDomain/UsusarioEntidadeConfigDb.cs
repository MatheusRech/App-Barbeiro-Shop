using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rech.Barbeiro.Shop.Domain.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rech.Barbeiro.Shop.Database.Base.ConfigDomain
{
    public class UsusarioEntidadeConfigDb : IEntityTypeConfiguration<UsuarioEntidade>
    {
        public void Configure(EntityTypeBuilder<UsuarioEntidade> builder)
        {
            builder.HasKey(u => u.Id);

            builder.HasIndex(u => u.NormalizedUserName).HasDatabaseName("UserNameIndex").IsUnique();
            builder.HasIndex(u => u.NormalizedEmail).HasDatabaseName("EmailIndex");

            builder.ToTable("AspNetUsers");

            builder.Property(u => u.ConcurrencyStamp).IsConcurrencyToken();

            builder.Property(u => u.UserName).HasMaxLength(256);
            builder.Property(u => u.NormalizedUserName).HasMaxLength(256);
            builder.Property(u => u.Email).HasMaxLength(256);
            builder.Property(u => u.NormalizedEmail).HasMaxLength(256);

            builder.HasOne(x => x.Barbearia).WithMany().HasForeignKey(x => x.BarbeariaId);
        }
    }
}
