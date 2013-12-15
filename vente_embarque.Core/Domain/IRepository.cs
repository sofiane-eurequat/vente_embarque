using vente_embarque.Core.Domain.Query;

namespace vente_embarque.Core.Domain
{
    public interface IRepository<T, TId> : IReadOnlyRepository<T, TId>, IRepositorySpec<T>
    where T : IAggregateRoot
    {
        void Save(T entity);
         
        void Add(T entity);
        void Remove(T entity);
    }
}
