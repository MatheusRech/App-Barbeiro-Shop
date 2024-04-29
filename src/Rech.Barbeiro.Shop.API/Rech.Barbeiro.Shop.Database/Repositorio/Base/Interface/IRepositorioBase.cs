using Rech.Barbeiro.Shop.Domain.Base;

namespace Rech.Barbeiro.Shop.Database.Repositorio.Base.Interface
{
    public interface IRepositorioBase<TEntidade> where TEntidade : Entidade
    {
        Task Atualizar(TEntidade entidade);
        Task<TEntidade> BuscarPorId(Guid id);
        Task Deletar(TEntidade entidade);
        Task Inserir(TEntidade entidade);
        IQueryable<TEntidade> Query();
    }
}
