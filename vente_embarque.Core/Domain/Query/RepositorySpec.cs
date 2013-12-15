using System.Collections.Generic;

namespace vente_embarque.Core.Domain.Query
{
    public interface IRepositorySpec<T> where T : IAggregateRoot
    {
        void SaveAll(IEnumerable<T> entities);
        List<T> FindAll(List<vente_embarque.Core.Domain.Query.Query> entities);
    }

  
}
