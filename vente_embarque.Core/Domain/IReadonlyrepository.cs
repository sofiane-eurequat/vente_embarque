using System.Collections.Generic;

namespace vente_embarque.Core.Domain
{
    public interface IReadOnlyRepository<T, TId> where T : IAggregateRoot
    {
        T FindBy(TId id);
        IEnumerable<T> FindAll();
        IEnumerable<T> FindBy(vente_embarque.Core.Domain.Query.Query query);
        IEnumerable<T> FindBy(vente_embarque.Core.Domain.Query.Query query, int index, int count);
    }
}
