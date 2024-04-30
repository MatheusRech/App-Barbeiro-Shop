using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
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
using System.Reflection;

namespace Rech.Barbeiro.Shop.Database.Base
{
    public class ContextoDatabase : IdentityDbContext<IdentityUser<Guid>, IdentityRole<Guid>, Guid>
    {

        public ContextoDatabase(DbContextOptions options) : base(options)
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
            builder.ApplyConfigurationsFromAssembly(Assembly.GetAssembly(typeof(AgendamentoEntidadeConfigDb)));
        }
    }
}
