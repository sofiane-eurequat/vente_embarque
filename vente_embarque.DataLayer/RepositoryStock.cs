using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo;
using vente_embarque.Core.Domain;
using vente_embarque.Core.Domain.Query;
using vente_embarque.DataLayer.Entities.Stock;
using vente_embarque.DataLayer.Helper;
using vente_embarque.Model;

namespace vente_embarque.DataLayer
{
    public class RepositoryStock: IRepository<Stock,Guid>
    {
        public Stock FindBy(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Stock> FindAll()
        {
            var config = new AppSettingsReader();
            var listestoks = new List<Stock>();
            using (
                var uow = new UnitOfWork
                    {
                    ConnectionString = ((string)config.GetValue("connect", typeof(string)))
                })
            {
                var stocks = new XPCollection<XpoStock>(uow);
                listestoks.AddRange(stocks.Select(xpoStock => Map.MapInverse.MapStock(xpoStock)));
            }
            return listestoks;
        }

        public IEnumerable<Stock> FindBy(Query query)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Stock> FindBy(Query query, int index, int count)
        {
            throw new NotImplementedException();
        }

        public void SaveAll(IEnumerable<Stock> entities)
        {
            throw new NotImplementedException();
        }

        public List<Stock> FindAll(List<Query> entities)
        {
            throw new NotImplementedException();
        }

        public void Save(Stock entity)
        {
            throw new NotImplementedException();
        }
        
        public void Save(Stock stock, ProductLine pl)
        {
            var config = new AppSettingsReader();
            using (
                var uow = new UnitOfWork
                {
                    ConnectionString = ((string)config.GetValue("connect", typeof(string)))
                })
            {
                var productLine = uow.GetObjectByKey<XpoProductLine>(pl.id);
                var product = uow.GetObjectByKey<XpoProduct>(pl.Product.id);
                productLine.Product = product;
                productLine.Quantity = pl.Quantity;
                uow.CommitChanges();
            }
        }

        public void Add(Stock entity)
        {
            var config = new AppSettingsReader();

            using (
                var uow = new UnitOfWork
                {
                    ConnectionString = ((string)config.GetValue("connect", typeof(string)))
                })
            {
                Map.Map.MapStock(entity, uow);
                uow.CommitChanges();
            }
        }

        public void Remove(Stock entity)
        {
            var config = new AppSettingsReader();
            using (
                var uow = new UnitOfWork
                {
                    ConnectionString = ((string)config.GetValue("connect", typeof(string)))
                })
            {
                var stock = uow.GetObjectByKey<XpoStock>(entity.id);
                uow.Delete(stock);
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
                var stock = uow.GetObjectByKey<XpoStock>(id);
               // foreach (var productLine in stock.ProductLines.ToList())
               // {
                //    productLine.Delete();
               // }
                stock.Delete();
                uow.CommitChanges();
            }
        }

        public void RemovePl(Guid id)
        {
            var config = new AppSettingsReader();
            using (
                var uow = new UnitOfWork
                {
                    ConnectionString = ((string)config.GetValue("connect", typeof(string)))
                })
            {
                var productLine = uow.GetObjectByKey<XpoProductLine>(id);
                productLine.Delete();
                uow.CommitChanges();
            }
        }
    }
}
