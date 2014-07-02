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
using vente_embarque.DataLayer.Entities.Stock;
using vente_embarque.Model;

namespace vente_embarque.DataLayer
{
    public class RepositoryOrder : IRepository<Order, Guid>
    {
        public Order FindBy(Guid id)
        {
            var config = new AppSettingsReader();
            using (
                var uow = new UnitOfWork
                {
                    ConnectionString = ((string)config.GetValue("connect", typeof(string)))
                })
            {
                var xpoorder = uow.GetObjectByKey<XpoOrder>(id);
                var order = Map.MapInverse.MapOrder(xpoorder);
                return order;
            }
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

        public void Save(Guid idOrder, OrderLine ol)
        {
            var config = new AppSettingsReader();
            using (
                var uow = new UnitOfWork
                {
                    ConnectionString = ((string)config.GetValue("connect", typeof(string)))
                })
            {
                var orderLine = uow.GetObjectByKey<XpoOrderLine>(ol.id);
                var product = uow.GetObjectByKey<XpoProduct>(ol.Product.id);
                orderLine.Product = product;
                orderLine.Quantity = ol.Quantity;
                uow.CommitChanges();
            }
        }

        public void Add(Order entity)
        {
            throw new NotImplementedException();
        }

        public void Remove(Order entity)
        {
            var config = new AppSettingsReader();
            using (
                var uow = new UnitOfWork
                {
                    ConnectionString = ((string)config.GetValue("connect", typeof(string)))
                })
            {
                var order = uow.GetObjectByKey<XpoOrder>(entity.id);
                uow.Delete(order);
                uow.CommitChanges();
            }
        }

        public void Remove(Guid id)
        {
            var config = new AppSettingsReader();
            using (
                var uow = new UnitOfWork
                {
                    ConnectionString = ((string)config.GetValue("connect", typeof(string)))
                })
            {
                var order = uow.GetObjectByKey<XpoOrder>(id);
                foreach (var orderLine in order.OrderLines.ToList())
                {
                    orderLine.Delete();
                }
                order.Delete();
                uow.CommitChanges();
            }
        }

        public void RemoveOl(Guid id)
        {
            var config = new AppSettingsReader();
            using (
                var uow = new UnitOfWork
                {
                    ConnectionString = ((string)config.GetValue("connect", typeof(string)))
                })
            {
                var orderLine = uow.GetObjectByKey<XpoOrderLine>(id);
                orderLine.Delete();
                uow.CommitChanges();
            }
        }
    }
}
