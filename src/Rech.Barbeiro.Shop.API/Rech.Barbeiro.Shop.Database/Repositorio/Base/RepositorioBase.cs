using Microsoft.EntityFrameworkCore;
using Rech.Barbeiro.Shop.Database.Base;
using Rech.Barbeiro.Shop.Database.Repositorio.Base.Interface;
using Rech.Barbeiro.Shop.Domain.Base;

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
