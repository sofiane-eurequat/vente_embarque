using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo;
using vente_embarque.Core.Domain;
using vente_embarque.Core.Domain.Query;
using vente_embarque.Model;

namespace vente_embarque.DataLayer
{
    class RepositoryOrder : IRepository<Order, Guid>
    {
        public Order FindBy(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Order> FindAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Order> FindBy(Query query)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Order> FindBy(Query query, int index, int count)
        {
            throw new NotImplementedException();
        }

        public void SaveAll(IEnumerable<Order> entities)
        {
            throw new NotImplementedException();
        }

        public List<Order> FindAll(List<Query> entities)
        {
            throw new NotImplementedException();
        }

        public void Save(Order entity)
        {

            using (
                var uow = new UnitOfWork()
                {
                    ConnectionString = @"data source=SOFYANE-PC\;integrated security=true;initial catalog=Inventaire;"
                })
            {
                Map.Map.MapOrder(entity, uow);
                uow.CommitChanges();
            }
        }

        public void Add(Order entity)
        {
            throw new NotImplementedException();
        }

        public void Remove(Order entity)
        {
            throw new NotImplementedException();
        }
    }
}
