using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo;
using vente_embarque.Core.Domain;
using vente_embarque.Core.Domain.Query;
using vente_embarque.DataLayer.Entities.Orders;
using vente_embarque.Model;

namespace vente_embarque.DataLayer
{
    public class RepositoryOrder : IRepository<Order, Guid>
    {
        public Order FindBy(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Order> FindAll()
        {
            var listeOrder = new List<Order>();
            var config = new AppSettingsReader();
            using (
                var uow = new UnitOfWork
                {
                    ConnectionString = ((string)config.GetValue("connect", typeof(string)))
                })
            {
                var orders = new XPCollection<XpoOrder>(uow);
                listeOrder.AddRange(orders.Select(Map.MapInverse.MapOrder));
            }
            return listeOrder;
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
            var config = new AppSettingsReader();
            using (
                var uow = new UnitOfWork()
                {
                    ConnectionString = ((string)config.GetValue("connect", typeof(string)))
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
