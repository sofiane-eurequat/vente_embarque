using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vente_embarque.Core.Domain;
using vente_embarque.Core.Domain.Query;
using vente_embarque.Model;

namespace vente_embarque.DataLayer
{
    class RepoitorySector : IRepository<Sector, Guid>
    {
        public Sector FindBy(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Sector> FindAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Sector> FindBy(Query query)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Sector> FindBy(Query query, int index, int count)
        {
            throw new NotImplementedException();
        }

        public void SaveAll(IEnumerable<Sector> entities)
        {
            throw new NotImplementedException();
        }

        public List<Sector> FindAll(List<Query> entities)
        {
            throw new NotImplementedException();
        }

        public void Save(Sector entity)
        {
            throw new NotImplementedException();
        }

        public void Add(Sector entity)
        {
            throw new NotImplementedException();
        }

        public void Remove(Sector entity)
        {
            throw new NotImplementedException();
        }
    }
}
