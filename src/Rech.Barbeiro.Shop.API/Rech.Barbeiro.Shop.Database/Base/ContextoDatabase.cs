using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Rech.Barbeiro.Shop.API.Helpers.Constantes;
using Rech.Barbeiro.Shop.Database.Base.ConfigDomain;
using Rech.Barbeiro.Shop.Domain.Agendamento;
using Rech.Barbeiro.Shop.Domain.AgendamentoFolga;
using Rech.Barbeiro.Shop.Domain.Barbearia;
using Rech.Barbeiro.Shop.Domain.Barbeiro;
using Rech.Barbeiro.Shop.Domain.Cliente;
using Rech.Barbeiro.Shop.Domain.ClienteEndereco;
using Rech.Barbeiro.Shop.Domain.DiasTrabalhoBarbeiro;
using Rech.Barbeiro.Shop.Domain.ServicoBarbearia;
using Rech.Barbeiro.Shop.Domain.ServicoBarbeiro;
using Rech.Barbeiro.Shop.Domain.Usuario;
using System.Reflection;

namespace Rech.Barbeiro.Shop.Database.Base
{
    public class ContextoDatabase : IdentityDbContext<UsuarioEntidade, IdentityRole<Guid>, Guid>
    {

        public ContextoDatabase(DbContextOptions<ContextoDatabase> options) : base(options)
        {
        }

        public DbSet<BarbeariaEntidade> Barbearias { get; set; }
        public DbSet<ServicoBarbeariaEntidade> ServicosBarbearias { get; set; }
        public DbSet<ClienteEntidade> Clientes { get; set; }
        public DbSet<ClienteEnderecoEntidade> EnderecoClientes { get; set; }
        public DbSet<BarbeiroEntidade> BarbeirosBarbearia { get; set; }
        public DbSet<DiasTrabalhoBarbeiroEntidade> DiasTrabalhoBarberio { get; set; }
        public DbSet<ServicoBarbeiroEntidade> ServicosBarbeiro { get; set; }
        public DbSet<AgendamentoEntidade> Agendamentos { get; set; }
        public DbSet<AgendamentoFolgaEntidade> FolgasBarbearia { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<IdentityRole<Guid>>().HasData(
                new IdentityRole<Guid>(PermissoesUsuario.Admin)
                {
                    Id = new Guid("19ba23e3-b4f1-4220-a884-090599dae20c"),
                    NormalizedName = PermissoesUsuario.Admin.ToUpper()
                },
                new IdentityRole<Guid>(PermissoesUsuario.Barbearia)
                {
                    Id = new Guid("ae4fedf9-0e99-46e6-b9ae-3843eb83ed99"),
                    NormalizedName = PermissoesUsuario.Barbearia.ToUpper()
                },
                new IdentityRole<Guid>(PermissoesUsuario.Cliente)
                {
                    Id = new Guid("3fe18c63-baa1-4bcb-815a-fd62821e5207"),
                    NormalizedName = PermissoesUsuario.Cliente.ToUpper()
                }
            );


            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(builder);
        }
    }
}
