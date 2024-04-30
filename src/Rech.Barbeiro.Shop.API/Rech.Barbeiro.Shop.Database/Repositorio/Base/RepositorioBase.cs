using Microsoft.EntityFrameworkCore;
using Rech.Barbeiro.Shop.Database.Base;
using Rech.Barbeiro.Shop.Domain.Base;
using Rech.Barbeiro.Shop.Domain.Interfaces;

namespace Rech.Barbeiro.Shop.Database.Repositorio.Base
{
    public class RepositorioBase<TEntidade> : IRepositorioBase<TEntidade> where TEntidade : Entidade
    {
        private readonly ContextoDatabase _contexto;
        
        protected DbSet<TEntidade> _tabela { get => _contexto.Set<TEntidade>(); }

        public RepositorioBase(ContextoDatabase contexto)
        {
            _contexto = contexto;
        }

        public async Task<TEntidade> BuscarPorId(Guid id)
        {
            return await _tabela.FirstOrDefaultAsync(t => t.Id == id);
        }

        public async Task<bool> EntidadeCadastrada(TEntidade entidade)
        {
            return await _tabela.AnyAsync(x => x.Id == entidade.Id);
        }

        public IQueryable<TEntidade> Query()
        {
            return _tabela.AsQueryable();
        }

        public async Task Inserir(TEntidade entidade)
        {
            await _tabela.AddAsync(entidade);
            await _contexto.SaveChangesAsync();
        }

        public async Task Atualizar(TEntidade entidade)
        {
            _tabela.Update(entidade);
            await _contexto.SaveChangesAsync();
        }

        public async Task Deletar(TEntidade entidade)
        {
            _tabela.Remove(entidade);
            await _contexto.SaveChangesAsync();
        }
    }
}
